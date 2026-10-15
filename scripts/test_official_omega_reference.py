import os
from pathlib import Path
import sqlite3
import tempfile
import unittest
from unittest.mock import patch
from contextlib import closing

from official_omega_reference import official_database, validate_database


class OfficialReferenceTests(unittest.TestCase):
    def test_missing_database_is_not_silently_created(self):
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "missing.db"
            with patch.dict(os.environ, {"OMEGA_OFFICIAL_DB": str(path)}):
                with self.assertRaisesRegex(RuntimeError, "missing or empty"):
                    official_database()
            self.assertFalse(path.exists())

    def test_existing_non_omega_schema_is_rejected(self):
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "wrong.db"
            with closing(sqlite3.connect(path)) as db:
                db.execute("CREATE TABLE unrelated(id INTEGER)")
                db.commit()
            with self.assertRaisesRegex(RuntimeError, "datas/texts schema"):
                validate_database(path)


if __name__ == "__main__":
    unittest.main()
