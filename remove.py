import os
from gitignore_parser import parse_gitignore

def delete_files_from_gitignore():
    gitignore_path = ".gitignore"

    gitignore = parse_gitignore(gitignore_path)

    totalDeleted = 0
    for root, dirnames, filenames in os.walk('.'):
        if '.git' in dirnames:
            dirnames.remove('.git')
            continue

        for filename in filenames:
            filepath = os.path.join(root, filename)
            if gitignore(filepath):
                os.remove(filepath)
                totalDeleted += 1
                print(f"Deleted '{filepath}'")

    print(f"Deletion complete. Total: {totalDeleted}")

# Usage
delete_files_from_gitignore()
