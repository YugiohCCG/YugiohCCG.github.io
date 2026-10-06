from __future__ import annotations

import base64
import csv
import hashlib
import json
import re
import unicodedata
from collections import OrderedDict
from dataclasses import dataclass, field
from pathlib import Path
from typing import Any, Iterable

from PIL import Image


TRIGGER = "hclar52"
TOP_KEYS = (
    "high_level_description",
    "style_description",
    "compositional_deconstruction",
)
STYLE_KEYS = ("aesthetics", "lighting", "medium", "art_style", "color_palette")
DECON_KEYS = ("background", "elements")
OBJ_KEYS = ("type", "bbox", "desc")
TEXT_KEYS = ("type", "bbox", "text", "desc")
MONSTER_TYPES = {
    "Spellcaster", "Dragon", "Zombie", "Warrior", "Beast-Warrior", "Beast",
    "Winged Beast", "Fiend", "Fairy", "Insect", "Dinosaur", "Reptile", "Fish",
    "Sea Serpent", "Aqua", "Pyro", "Thunder", "Rock", "Plant", "Machine",
    "Psychic", "Divine-Beast", "Wyrm", "Cyberse", "Illusion",
}
SPELL_SUBTYPES = {"Normal", "Continuous", "Equip", "Field", "Quick-Play", "Ritual"}
TRAP_SUBTYPES = {"Normal", "Continuous", "Counter"}
HEX_RE = re.compile(r"^#[0-9A-F]{6}$")
HEX3_RE = re.compile(r"^#[0-9a-fA-F]{3}$")
HEX6_LOOSE_RE = re.compile(r"^#[0-9a-fA-F]{6}$")
HEDGE_RE = re.compile(
    r"\b(possibly|perhaps|maybe|might be|could be|appears to be|seems to be|"
    r"or similar|some kind of|implied|suggested|hinted)\b",
    re.IGNORECASE,
)
PLACEHOLDERS = ("[name]", "[trigger]")


class DuplicateKeyError(ValueError):
    pass


class DraftNormalizationError(ValueError):
    pass


@dataclass
class Finding:
    severity: str
    code: str
    message: str
    dataset_id: str = ""
    path: str = ""

    def as_dict(self) -> dict[str, str]:
        return {
            "severity": self.severity,
            "code": self.code,
            "message": self.message,
            "dataset_id": self.dataset_id,
            "path": self.path,
        }


@dataclass
class ValidationResult:
    findings: list[Finding] = field(default_factory=list)

    @property
    def errors(self) -> list[Finding]:
        return [item for item in self.findings if item.severity == "ERROR"]

    @property
    def reviews(self) -> list[Finding]:
        return [item for item in self.findings if item.severity == "REVIEW"]

    def add(
        self,
        severity: str,
        code: str,
        message: str,
        *,
        dataset_id: str = "",
        path: str = "",
    ) -> None:
        self.findings.append(Finding(severity, code, message, dataset_id, path))


def _no_duplicate_pairs(pairs: list[tuple[str, Any]]) -> OrderedDict[str, Any]:
    output: OrderedDict[str, Any] = OrderedDict()
    for key, value in pairs:
        if key in output:
            raise DuplicateKeyError(f"duplicate JSON key: {key}")
        output[key] = value
    return output


def parse_json_strict(raw: str) -> OrderedDict[str, Any]:
    value = json.loads(
        raw,
        object_pairs_hook=_no_duplicate_pairs,
        parse_constant=lambda token: (_ for _ in ()).throw(
            ValueError(f"non-finite JSON number: {token}")
        ),
    )
    if not isinstance(value, OrderedDict):
        raise ValueError("caption root must be a JSON object")
    return value


def extract_json_object(raw: str) -> OrderedDict[str, Any]:
    text = raw.strip()
    fence = re.fullmatch(r"```(?:json)?\s*(.*?)\s*```", text, re.DOTALL | re.IGNORECASE)
    if fence:
        text = fence.group(1).strip()
    try:
        return parse_json_strict(text)
    except (json.JSONDecodeError, ValueError, DuplicateKeyError):
        start, end = text.find("{"), text.rfind("}")
        if start < 0 or end <= start:
            raise DraftNormalizationError("VLM response contains no JSON object")
        try:
            return parse_json_strict(text[start : end + 1])
        except (json.JSONDecodeError, ValueError, DuplicateKeyError) as exc:
            raise DraftNormalizationError(f"VLM response is not valid unique-key JSON: {exc}") from exc


def model_string(caption: dict[str, Any]) -> str:
    return json.dumps(caption, ensure_ascii=False, separators=(",", ":"), allow_nan=False)


def sha256_bytes(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def sha256_file(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as handle:
        for chunk in iter(lambda: handle.read(1024 * 1024), b""):
            digest.update(chunk)
    return digest.hexdigest()


def load_manifest(path: Path) -> list[dict[str, Any]]:
    if path.suffix.lower() == ".json":
        value = json.loads(path.read_text(encoding="utf-8-sig"))
        if not isinstance(value, list) or not all(isinstance(row, dict) for row in value):
            raise ValueError("JSON manifest must be an array of objects")
        return value
    with path.open("r", encoding="utf-8-sig", newline="") as handle:
        return list(csv.DictReader(handle))


def write_pretty_json(path: Path, value: dict[str, Any]) -> None:
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(
        json.dumps(value, ensure_ascii=False, indent=2, allow_nan=False) + "\n",
        encoding="utf-8",
    )


def resolve_dataset_path(dataset_root: Path, value: str, fallback_dir: str, dataset_id: str, suffix: str) -> Path:
    if value:
        candidate = Path(value)
        return candidate if candidate.is_absolute() else dataset_root / candidate
    return dataset_root / fallback_dir / f"{dataset_id}{suffix}"


def image_data_uri(path: Path) -> str:
    mime = "image/png" if path.suffix.lower() == ".png" else "image/jpeg"
    return f"data:{mime};base64,{base64.b64encode(path.read_bytes()).decode('ascii')}"


def word_count(value: str) -> int:
    return len(re.findall(r"\b[\w'-]+\b", value, flags=re.UNICODE))


def normalize_phrase(value: str) -> str:
    value = unicodedata.normalize("NFKC", str(value or "")).casefold()
    value = value.translate(str.maketrans({
        "’": "'", "‘": "'", "`": "'", "–": "-", "—": "-", "−": "-",
    }))
    value = re.sub(r"[^\w]+", " ", value, flags=re.UNICODE)
    return " ".join(value.split())


def iter_string_leaves(value: Any, path: str = "root") -> Iterable[tuple[str, str]]:
    if isinstance(value, str):
        yield path, value
    elif isinstance(value, dict):
        for key, child in value.items():
            yield from iter_string_leaves(child, f"{path}.{key}")
    elif isinstance(value, list):
        for index, child in enumerate(value):
            yield from iter_string_leaves(child, f"{path}[{index}]")


def split_alias_field(value: Any) -> list[str]:
    if isinstance(value, list):
        return [str(item).strip() for item in value if str(item).strip()]
    if not value:
        return []
    raw = str(value).strip()
    if raw.startswith("["):
        try:
            parsed = json.loads(raw)
            if isinstance(parsed, list):
                return [str(item).strip() for item in parsed if str(item).strip()]
        except json.JSONDecodeError:
            pass
    return [item.strip() for item in re.split(r"\s*[|;]\s*", raw) if item.strip()]


def denial_phrases(row: dict[str, Any]) -> list[tuple[str, str]]:
    names: list[tuple[str, str]] = []
    for field_name in (
        "card_name", "source_name", "archetype", "localized_names", "alternate_names",
        "aliases", "romanizations", "artist", "watermark_credit", "set_code",
    ):
        for value in split_alias_field(row.get(field_name)):
            normalized = normalize_phrase(value)
            if normalized:
                names.append((field_name, normalized))
    for field_name in ("passcode",):
        value = str(row.get(field_name) or "").strip()
        if value:
            names.append((field_name, normalize_phrase(value)))
    unique: list[tuple[str, str]] = []
    seen: set[str] = set()
    for source, phrase in names:
        if phrase not in seen:
            unique.append((source, phrase))
            seen.add(phrase)
    return unique


def metadata_prefix(row: dict[str, Any]) -> str:
    category = str(row.get("card_category") or "").strip()
    if category == "Monster":
        monster_type = str(row.get("monster_type") or "").strip()
        if monster_type not in MONSTER_TYPES:
            raise DraftNormalizationError(f"invalid or missing Monster Type: {monster_type!r}")
        article = "An" if monster_type[0].casefold() in "aeiou" else "A"
        return f"{article} {monster_type}-type MONSTER card artwork showing the following scene:"
    subtype = str(row.get("spell_trap_subtype") or "").strip()
    if category == "Spell":
        if subtype not in SPELL_SUBTYPES:
            raise DraftNormalizationError(f"invalid or missing Spell subtype: {subtype!r}")
        return f"A {subtype} SPELL card artwork showing the following scene:"
    if category == "Trap":
        if subtype not in TRAP_SUBTYPES:
            raise DraftNormalizationError(f"invalid or missing Trap subtype: {subtype!r}")
        return f"A {subtype} TRAP card artwork showing the following scene:"
    raise DraftNormalizationError(f"invalid card category: {category!r}")


def _summary_fragment(value: str) -> str:
    text = " ".join(value.strip().split())
    text = re.sub(r"^(?:this image (?:shows|depicts)|the image (?:shows|depicts))\s+", "", text, flags=re.I)
    if text.startswith("A "):
        text = "a " + text[2:]
    elif text.startswith("An "):
        text = "an " + text[3:]
    elif text and text[0].isupper():
        text = text[0].lower() + text[1:]
    return text.rstrip(". ")


def normalize_palette(value: Any) -> list[str]:
    if not isinstance(value, list):
        raise DraftNormalizationError("style_description.color_palette must be an array")
    output: list[str] = []
    for item in value:
        if not isinstance(item, str):
            raise DraftNormalizationError("palette entries must be strings")
        raw = item.strip()
        if HEX3_RE.fullmatch(raw):
            raw = "#" + "".join(character * 2 for character in raw[1:])
        if not HEX6_LOOSE_RE.fullmatch(raw):
            raise DraftNormalizationError(f"invalid palette color: {item!r}")
        canonical = raw.upper()
        if canonical not in output:
            output.append(canonical)
    if not 1 <= len(output) <= 16:
        raise DraftNormalizationError("palette must contain 1-16 unique colors")
    return output


def _convert_explicit_bbox(value: Any, source_format: str) -> list[int]:
    if not isinstance(value, list) or len(value) != 4:
        raise DraftNormalizationError("bbox must be an array of four integers")
    if any(isinstance(item, bool) or not isinstance(item, int) for item in value):
        raise DraftNormalizationError("bbox values must be integers")
    if source_format == "stored_yxyx":
        output = list(value)
    elif source_format == "qwen_xyxy":
        x1, y1, x2, y2 = value
        output = [y1, x1, y2, x2]
    else:
        raise DraftNormalizationError(f"unsupported bbox_response_format: {source_format!r}")
    ymin, xmin, ymax, xmax = output
    if not (0 <= ymin < ymax <= 1000 and 0 <= xmin < xmax <= 1000):
        raise DraftNormalizationError(f"invalid stored bbox extent: {output}")
    return output


def normalize_draft(
    draft: dict[str, Any],
    row: dict[str, Any],
    *,
    bbox_source_format: str = "stored_yxyx",
) -> OrderedDict[str, Any]:
    if set(draft) - set(TOP_KEYS) - {"aspect_ratio"}:
        raise DraftNormalizationError(f"unknown draft top-level keys: {sorted(set(draft) - set(TOP_KEYS) - {'aspect_ratio'})}")
    if any(TRIGGER in value for _, value in iter_string_leaves(draft)):
        raise DraftNormalizationError("draft unexpectedly contains the reserved trigger")
    for placeholder in PLACEHOLDERS:
        if any(placeholder in value for _, value in iter_string_leaves(draft)):
            raise DraftNormalizationError(f"draft contains forbidden placeholder {placeholder}")

    hld = draft.get("high_level_description")
    style = draft.get("style_description")
    decon = draft.get("compositional_deconstruction")
    if not isinstance(hld, str) or not hld.strip():
        raise DraftNormalizationError("draft high_level_description must be a non-empty string")
    if not isinstance(style, dict):
        raise DraftNormalizationError("draft style_description must be an object")
    if not isinstance(decon, dict):
        raise DraftNormalizationError("draft compositional_deconstruction must be an object")
    for key in ("aesthetics", "lighting", "art_style"):
        if not isinstance(style.get(key), str) or not style[key].strip():
            raise DraftNormalizationError(f"draft style_description.{key} must be non-empty")
    if style.get("photo") is not None:
        raise DraftNormalizationError("photo branch is forbidden for this illustration dataset")
    if style.get("medium") not in (None, "illustration"):
        raise DraftNormalizationError(f"non-illustration draft medium: {style.get('medium')!r}")
    unknown_style = set(style) - {"aesthetics", "lighting", "medium", "art_style", "color_palette"}
    if unknown_style:
        raise DraftNormalizationError(f"unknown draft style keys: {sorted(unknown_style)}")
    if set(decon) - set(DECON_KEYS):
        raise DraftNormalizationError(f"unknown deconstruction keys: {sorted(set(decon) - set(DECON_KEYS))}")
    if not isinstance(decon.get("background"), str) or not decon["background"].strip():
        raise DraftNormalizationError("background must be a non-empty string")
    if not isinstance(decon.get("elements"), list) or not decon["elements"]:
        raise DraftNormalizationError("elements must be a non-empty array")

    elements: list[OrderedDict[str, Any]] = []
    for index, element in enumerate(decon["elements"]):
        if not isinstance(element, dict):
            raise DraftNormalizationError(f"elements[{index}] must be an object")
        element_type = element.get("type")
        allowed = set(TEXT_KEYS if element_type == "text" else OBJ_KEYS)
        if element_type not in {"obj", "text"}:
            raise DraftNormalizationError(f"elements[{index}].type must be obj or text")
        if set(element) - allowed:
            raise DraftNormalizationError(f"elements[{index}] has forbidden keys: {sorted(set(element) - allowed)}")
        output_element: OrderedDict[str, Any] = OrderedDict()
        output_element["type"] = element_type
        if "bbox" in element:
            output_element["bbox"] = _convert_explicit_bbox(element["bbox"], bbox_source_format)
        if element_type == "text":
            if not isinstance(element.get("text"), str) or not element["text"]:
                raise DraftNormalizationError(f"elements[{index}].text must be non-empty")
            output_element["text"] = element["text"]
        if not isinstance(element.get("desc"), str) or not element["desc"].strip():
            raise DraftNormalizationError(f"elements[{index}].desc must be non-empty")
        output_element["desc"] = " ".join(element["desc"].strip().split())
        elements.append(output_element)

    output: OrderedDict[str, Any] = OrderedDict()
    output["high_level_description"] = f"{metadata_prefix(row)} {_summary_fragment(hld)}."
    output_style: OrderedDict[str, Any] = OrderedDict()
    output_style["aesthetics"] = " ".join(style["aesthetics"].strip().split())
    output_style["lighting"] = " ".join(style["lighting"].strip().split())
    output_style["medium"] = "illustration"
    technique = " ".join(style["art_style"].strip().split())
    output_style["art_style"] = f"{TRIGGER} card illustration, {technique}"
    output_style["color_palette"] = normalize_palette(style.get("color_palette"))
    output["style_description"] = output_style
    output_decon: OrderedDict[str, Any] = OrderedDict()
    output_decon["background"] = " ".join(decon["background"].strip().split())
    output_decon["elements"] = elements
    output["compositional_deconstruction"] = output_decon
    return output


def dhash(path: Path, hash_size: int = 8) -> int:
    with Image.open(path) as image:
        gray = image.convert("L").resize((hash_size + 1, hash_size), Image.Resampling.LANCZOS)
        pixels = list(gray.getdata())
    value = 0
    width = hash_size + 1
    for y in range(hash_size):
        for x in range(hash_size):
            value = (value << 1) | int(pixels[y * width + x] > pixels[y * width + x + 1])
    return value


def hamming_distance(left: int, right: int) -> int:
    return (left ^ right).bit_count()
