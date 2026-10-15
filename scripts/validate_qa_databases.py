"""Fail before QA when a real required database is missing or malformed."""
from pathlib import Path
from official_omega_reference import official_database, validate_database

root = Path(__file__).resolve().parents[1]
validate_database(root / "public" / "CCG Downloads" / "CCG_Database" / "CCG_v1.db")
official_database()
print("Canonical CCG and pinned official Omega datas/texts schemas validated.")
