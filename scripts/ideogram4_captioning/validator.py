from __future__ import annotations

import re
from pathlib import Path
from typing import Any

from PIL import Image

from common import (
    DECON_KEYS,
    HEDGE_RE,
    HEX_RE,
    MONSTER_TYPES,
    OBJ_KEYS,
    PLACEHOLDERS,
    SPELL_SUBTYPES,
    STYLE_KEYS,
    TEXT_KEYS,
    TOP_KEYS,
    TRAP_SUBTYPES,
    TRIGGER,
    ValidationResult,
    denial_phrases,
    iter_string_leaves,
    metadata_prefix,
    model_string,
    normalize_phrase,
    parse_json_strict,
    resolve_dataset_path,
    sha256_file,
    word_count,
)


def _keys_equal(value: Any, expected: tuple[str, ...]) -> bool:
    return isinstance(value, dict) and tuple(value.keys()) == expected


def _phrase_present(haystack: str, phrase: str) -> bool:
    if not phrase:
        return False
    return re.search(rf"(?<!\w){re.escape(phrase)}(?!\w)", haystack, re.UNICODE) is not None


GENERIC_FILLER_RE = re.compile(
    r"\bthe artwork is rendered with fine details, showcasing the distinct characteristics of the subject clearly\b",
    re.IGNORECASE,
)
CORRUPTED_CREATURE_RE = re.compile(
    r"\b(?:creature\s+creature|creature-and|and-creature|creature\s+(?:light|energy))\b",
    re.IGNORECASE,
)


def validate_caption(
    raw: str,
    row: dict[str, Any],
    *,
    caption_path: str = "",
) -> tuple[ValidationResult, dict[str, Any] | None]:
    result = ValidationResult()
    dataset_id = str(row.get("dataset_id") or "")

    if raw.startswith("\ufeff"):
        result.add("ERROR", "caption.bom", "caption must not begin with a UTF-8 BOM", dataset_id=dataset_id, path=caption_path)
    if "```" in raw:
        result.add("ERROR", "caption.markdown_fence", "caption contains a Markdown fence", dataset_id=dataset_id, path=caption_path)
    if re.search(r"\\u[0-9a-fA-F]{4}", raw):
        result.add("ERROR", "caption.unicode_escape", "caption stores a Unicode escape instead of literal UTF-8", dataset_id=dataset_id, path=caption_path)

    try:
        caption = parse_json_strict(raw)
    except Exception as exc:
        result.add("ERROR", "caption.invalid_json", str(exc), dataset_id=dataset_id, path=caption_path)
        return result, None

    if not _keys_equal(caption, TOP_KEYS):
        result.add("ERROR", "schema.top_keys", f"top-level keys/order must be {TOP_KEYS}, got {tuple(caption.keys())}", dataset_id=dataset_id, path=caption_path)

    hld = caption.get("high_level_description")
    if not isinstance(hld, str) or not hld.strip():
        result.add("ERROR", "schema.hld", "high_level_description must be non-empty text", dataset_id=dataset_id, path=caption_path)
    else:
        try:
            required_prefix = metadata_prefix(row) + " "
            if not hld.startswith(required_prefix):
                result.add("ERROR", "metadata.hld_prefix", f"high_level_description must start with {required_prefix!r}", dataset_id=dataset_id, path=caption_path)
        except Exception as exc:
            result.add("ERROR", "metadata.invalid", str(exc), dataset_id=dataset_id, path=caption_path)
        if word_count(hld) > 50:
            result.add("ERROR", "caption.hld_word_cap", f"high_level_description has {word_count(hld)} words; maximum is 50", dataset_id=dataset_id, path=caption_path)

    style = caption.get("style_description")
    if not _keys_equal(style, STYLE_KEYS):
        got = tuple(style.keys()) if isinstance(style, dict) else type(style).__name__
        result.add("ERROR", "schema.style_keys", f"style keys/order must be {STYLE_KEYS}, got {got}", dataset_id=dataset_id, path=caption_path)
    if isinstance(style, dict):
        for key in ("aesthetics", "lighting", "art_style"):
            if not isinstance(style.get(key), str) or not style[key].strip():
                result.add("ERROR", f"schema.style_{key}", f"style_description.{key} must be non-empty text", dataset_id=dataset_id, path=caption_path)
        if style.get("medium") != "illustration":
            result.add("ERROR", "schema.medium", "medium must be exactly 'illustration'", dataset_id=dataset_id, path=caption_path)
        art_style = style.get("art_style")
        if isinstance(art_style, str) and not art_style.startswith(f"{TRIGGER} card illustration"):
            result.add("ERROR", "trigger.location", "art_style must begin with 'hclar52 card illustration'", dataset_id=dataset_id, path=caption_path)
        palette = style.get("color_palette")
        if not isinstance(palette, list) or not 1 <= len(palette) <= 16:
            result.add("ERROR", "palette.count", "color_palette must contain 1-16 entries", dataset_id=dataset_id, path=caption_path)
        else:
            if len(set(palette)) != len(palette):
                result.add("ERROR", "palette.duplicate", "color_palette contains duplicates", dataset_id=dataset_id, path=caption_path)
            for index, color in enumerate(palette):
                if not isinstance(color, str) or not HEX_RE.fullmatch(color):
                    result.add("ERROR", "palette.format", f"color_palette[{index}] is not uppercase #RRGGBB", dataset_id=dataset_id, path=caption_path)

    decon = caption.get("compositional_deconstruction")
    if not _keys_equal(decon, DECON_KEYS):
        got = tuple(decon.keys()) if isinstance(decon, dict) else type(decon).__name__
        result.add("ERROR", "schema.decon_keys", f"deconstruction keys/order must be {DECON_KEYS}, got {got}", dataset_id=dataset_id, path=caption_path)
    if isinstance(decon, dict):
        if not isinstance(decon.get("background"), str) or not decon["background"].strip():
            result.add("ERROR", "schema.background", "background must be non-empty text", dataset_id=dataset_id, path=caption_path)
        elements = decon.get("elements")
        if not isinstance(elements, list) or not elements:
            result.add("ERROR", "schema.elements", "elements must be a non-empty array", dataset_id=dataset_id, path=caption_path)
        else:
            for index, element in enumerate(elements):
                item_path = f"{caption_path}#elements[{index}]"
                if not isinstance(element, dict):
                    result.add("ERROR", "schema.element", "element must be an object", dataset_id=dataset_id, path=item_path)
                    continue
                element_type = element.get("type")
                expected = TEXT_KEYS if element_type == "text" else OBJ_KEYS if element_type == "obj" else ()
                expected_present = tuple(key for key in expected if key != "bbox" or "bbox" in element)
                if not expected or tuple(element.keys()) != expected_present:
                    result.add("ERROR", "schema.element_keys", f"wrong element keys/order; expected {expected_present}, got {tuple(element.keys())}", dataset_id=dataset_id, path=item_path)
                bbox = element.get("bbox")
                if bbox is not None:
                    valid_bbox = (
                        isinstance(bbox, list)
                        and len(bbox) == 4
                        and all(isinstance(value, int) and not isinstance(value, bool) for value in bbox)
                    )
                    if not valid_bbox:
                        result.add("ERROR", "bbox.structure", "bbox must be four non-boolean integers in stored yxyx order", dataset_id=dataset_id, path=item_path)
                    else:
                        ymin, xmin, ymax, xmax = bbox
                        if not (0 <= ymin < ymax <= 1000 and 0 <= xmin < xmax <= 1000):
                            result.add("ERROR", "bbox.extent", f"invalid stored [ymin,xmin,ymax,xmax] bbox {bbox}", dataset_id=dataset_id, path=item_path)
                if element_type == "text" and (not isinstance(element.get("text"), str) or not element["text"]):
                    result.add("ERROR", "schema.text_literal", "text element requires non-empty literal text", dataset_id=dataset_id, path=item_path)
                desc = element.get("desc")
                if not isinstance(desc, str) or not desc.strip():
                    result.add("ERROR", "schema.element_desc", "element desc must be non-empty text", dataset_id=dataset_id, path=item_path)
                elif element_type == "obj" and not 30 <= word_count(desc) <= 60:
                    result.add("ERROR", "caption.element_word_count", f"object description has {word_count(desc)} words; required 30-60", dataset_id=dataset_id, path=item_path)

    leaves = list(iter_string_leaves(caption))
    trigger_locations = [path for path, value in leaves for _ in range(value.count(TRIGGER))]
    if trigger_locations != ["root.style_description.art_style"]:
        result.add("ERROR", "trigger.count_or_location", f"trigger must occur exactly once in art_style; found {trigger_locations}", dataset_id=dataset_id, path=caption_path)
    for placeholder in PLACEHOLDERS:
        for leaf_path, value in leaves:
            if placeholder in value:
                result.add("ERROR", "caption.placeholder", f"forbidden placeholder {placeholder} in {leaf_path}", dataset_id=dataset_id, path=caption_path)
    for leaf_path, value in leaves:
        match = HEDGE_RE.search(value)
        if match:
            result.add("ERROR", "caption.hedging", f"hedging phrase {match.group(0)!r} in {leaf_path}", dataset_id=dataset_id, path=caption_path)
        match = GENERIC_FILLER_RE.search(value)
        if match:
            result.add("ERROR", "caption.generic_filler", f"generic filler occurs in {leaf_path}", dataset_id=dataset_id, path=caption_path)
        match = CORRUPTED_CREATURE_RE.search(value)
        if match:
            result.add("ERROR", "caption.corrupted_phrase", f"likely corrupted phrase {match.group(0)!r} in {leaf_path}", dataset_id=dataset_id, path=caption_path)

    normalized_leaves = [(path, normalize_phrase(value)) for path, value in leaves]
    for source_field, phrase in denial_phrases(row):
        for leaf_path, normalized_value in normalized_leaves:
            if _phrase_present(normalized_value, phrase):
                result.add("ERROR", "caption.name_leak", f"denied {source_field} phrase {phrase!r} occurs in {leaf_path}", dataset_id=dataset_id, path=caption_path)

    try:
        compact = model_string(caption)
        if model_string(parse_json_strict(compact)) != compact:
            result.add("ERROR", "caption.roundtrip", "compact model string is not byte-stable", dataset_id=dataset_id, path=caption_path)
    except Exception as exc:
        result.add("ERROR", "caption.serialization", str(exc), dataset_id=dataset_id, path=caption_path)
    return result, caption


def validate_image(path: Path, row: dict[str, Any]) -> ValidationResult:
    result = ValidationResult()
    dataset_id = str(row.get("dataset_id") or "")
    if not path.is_file():
        result.add("ERROR", "image.missing", "image file is missing", dataset_id=dataset_id, path=str(path))
        return result
    try:
        with Image.open(path) as probe:
            probe.verify()
        with Image.open(path) as image:
            if image.size != (1024, 1024):
                result.add("ERROR", "image.dimensions", f"expected 1024x1024, got {image.width}x{image.height}", dataset_id=dataset_id, path=str(path))
            if image.mode != "RGB":
                result.add("ERROR", "image.mode", f"expected opaque RGB, got {image.mode}", dataset_id=dataset_id, path=str(path))
            if image.getexif().get(274) not in (None, 1):
                result.add("ERROR", "image.orientation", "prepared image retains a non-normal EXIF orientation", dataset_id=dataset_id, path=str(path))
            image.load()
    except Exception as exc:
        result.add("ERROR", "image.decode", f"image does not decode completely: {exc}", dataset_id=dataset_id, path=str(path))
        return result

    expected = str(row.get("output_sha256") or row.get("prepared_image_sha256") or "").strip().lower()
    actual = sha256_file(path)
    if expected and expected != actual:
        result.add("ERROR", "image.sha256", f"prepared image hash mismatch: expected {expected}, got {actual}", dataset_id=dataset_id, path=str(path))
    try:
        width = int(row.get("source_width") or 0)
        height = int(row.get("source_height") or 0)
        if width and height and min(width, height) < 1024:
            result.add("REVIEW", "image.low_resolution_upscale", f"source was {width}x{height}", dataset_id=dataset_id, path=str(path))
    except (TypeError, ValueError):
        pass
    return result


def validate_manifest_metadata(row: dict[str, Any]) -> ValidationResult:
    result = ValidationResult()
    dataset_id = str(row.get("dataset_id") or "")
    category = str(row.get("card_category") or "")
    if category not in {"Monster", "Spell", "Trap"}:
        result.add("ERROR", "metadata.category", f"invalid category {category!r}", dataset_id=dataset_id)
    if category == "Monster" and str(row.get("monster_type") or "") not in MONSTER_TYPES:
        result.add("ERROR", "metadata.monster_type", "missing/invalid Monster Type", dataset_id=dataset_id)
    subtype = str(row.get("spell_trap_subtype") or "")
    if category == "Spell" and subtype not in SPELL_SUBTYPES:
        result.add("ERROR", "metadata.spell_subtype", f"invalid Spell subtype {subtype!r}", dataset_id=dataset_id)
    if category == "Trap" and subtype not in TRAP_SUBTYPES:
        result.add("ERROR", "metadata.trap_subtype", f"invalid Trap subtype {subtype!r}", dataset_id=dataset_id)
    status = str(row.get("official_metadata_status") or "").casefold()
    if not status or "pending" in status or "unverified" in status:
        result.add("REVIEW", "metadata.official_verification", "official metadata verification is unresolved", dataset_id=dataset_id)
    bbox_format = str(row.get("bbox_source_format") or "").strip()
    if bbox_format and bbox_format != "stored_yxyx":
        result.add("ERROR", "metadata.bbox_format", f"final manifest bbox_source_format must be stored_yxyx, got {bbox_format!r}", dataset_id=dataset_id)
    return result


def validate_pair(dataset_root: Path, row: dict[str, Any]) -> tuple[ValidationResult, dict[str, Any] | None]:
    result = validate_manifest_metadata(row)
    dataset_id = str(row.get("dataset_id") or "")
    image_path = resolve_dataset_path(dataset_root, str(row.get("image_file") or ""), "images", dataset_id, ".png")
    caption_path = resolve_dataset_path(dataset_root, str(row.get("caption_file") or ""), "captions", dataset_id, ".json")
    if image_path.stem != dataset_id or caption_path.stem != dataset_id:
        result.add("ERROR", "pair.stem", "dataset_id and image/caption stems must match", dataset_id=dataset_id)
    result.findings.extend(validate_image(image_path, row).findings)
    if not caption_path.is_file():
        result.add("ERROR", "caption.missing", "caption file is missing", dataset_id=dataset_id, path=str(caption_path))
        return result, None
    try:
        raw = caption_path.read_text(encoding="utf-8")
    except Exception as exc:
        result.add("ERROR", "caption.read", str(exc), dataset_id=dataset_id, path=str(caption_path))
        return result, None
    caption_result, caption = validate_caption(raw, row, caption_path=str(caption_path))
    result.findings.extend(caption_result.findings)
    expected_hash = str(row.get("model_caption_sha256") or "").strip().lower()
    if expected_hash and caption is not None:
        import hashlib

        actual_hash = hashlib.sha256(model_string(caption).encode("utf-8")).hexdigest()
        if actual_hash != expected_hash:
            result.add("ERROR", "caption.sha256", f"model caption hash mismatch: expected {expected_hash}, got {actual_hash}", dataset_id=dataset_id, path=str(caption_path))
    return result, caption
