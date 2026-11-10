"""Validate every tracked text file; Git attributes identify binary assets."""

from pathlib import Path
import subprocess
import sys


def main() -> int:
    names = subprocess.check_output(["git", "ls-files", "-z"])
    attributes = subprocess.check_output(
        ["git", "check-attr", "-z", "--stdin", "text"], input=names
    ).split(b"\0")
    binary = {
        attributes[i]
        for i in range(0, len(attributes) - 1, 3)
        if attributes[i + 2] == b"unset"
    }
    checked = 0
    failures = []
    for name in filter(None, names.split(b"\0")):
        if name in binary:
            continue
        path = Path(name.decode("utf-8"))
        try:
            path.read_bytes().decode("utf-8-sig")
        except UnicodeDecodeError as error:
            failures.append(f"{path.as_posix()}: invalid UTF-8 at byte {error.start}")
        checked += 1
    if failures:
        print("UTF-8 validation failed:", *failures, sep="\n")
        return 1
    print(f"UTF-8 validated: {checked} tracked text files; {len(binary)} binary assets excluded.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
