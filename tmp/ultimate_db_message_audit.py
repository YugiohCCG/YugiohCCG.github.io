import json
import re
import sqlite3
from pathlib import Path

repo = Path(__file__).resolve().parents[1]
cards = json.loads((repo / "src/data/cards.json").read_text(encoding="utf-8"))
scripts = repo / "public/CCG Downloads/CCG_Scripts"
db_path = repo / "public/CCG Downloads/CCG_Database/CCG_v1.db"

connection = sqlite3.connect(f"file:{db_path.as_posix()}?mode=ro", uri=True)
connection.row_factory = sqlite3.Row
missing_rows = []
metadata_mismatches = []
blank_messages = []
message_uses = 0

try:
    cursor = connection.cursor()
    for ordinal, card in enumerate(cards, 1):
        card_id = int(card["passcode"])
        data_row = cursor.execute("SELECT * FROM datas WHERE id=?", (card_id,)).fetchone()
        text_row = cursor.execute("SELECT * FROM texts WHERE id=?", (card_id,)).fetchone()
        if data_row is None or text_row is None:
            missing_rows.append(
                {
                    "ordinal": ordinal,
                    "id": card_id,
                    "name": card["name"],
                    "datas": data_row is not None,
                    "texts": text_row is not None,
                }
            )
            continue
        if text_row["name"] != card["name"]:
            metadata_mismatches.append(
                {
                    "ordinal": ordinal,
                    "id": card_id,
                    "field": "name",
                    "json": card["name"],
                    "db": text_row["name"],
                }
            )
        if text_row["desc"] != card["text"]:
            metadata_mismatches.append(
                {
                    "ordinal": ordinal,
                    "id": card_id,
                    "field": "desc",
                }
            )
        script_path = scripts / f"c{card_id}.lua"
        if not script_path.exists():
            continue
        script = script_path.read_text(encoding="utf-8")
        indices = sorted(
            {
                int(match.group(1))
                for match in re.finditer(
                    rf"aux\.Stringid\s*\(\s*(?:id|{card_id})\s*,\s*(\d+)\s*\)",
                    script,
                )
            }
        )
        message_uses += len(indices)
        for index in indices:
            column = f"str{index + 1}"
            if column not in text_row.keys() or not text_row[column]:
                blank_messages.append(
                    {
                        "ordinal": ordinal,
                        "id": card_id,
                        "name": card["name"],
                        "index": index,
                        "column": column,
                    }
                )
finally:
    connection.close()

report = {
    "cards": len(cards),
    "message_indices_used": message_uses,
    "missing_rows": missing_rows,
    "metadata_mismatches": metadata_mismatches,
    "blank_messages": blank_messages,
}
(repo / "tmp/ultimate_db_message_findings.json").write_text(
    json.dumps(report, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
)
print(
    f"cards={len(cards)} message_indices_used={message_uses} "
    f"missing_rows={len(missing_rows)} metadata_mismatches={len(metadata_mismatches)} "
    f"blank_messages={len(blank_messages)} blank_cards={len({row['id'] for row in blank_messages})}"
)
