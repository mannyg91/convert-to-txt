using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeToTxt
{
    public class CodeScanner
    {
        public List<string> FilterFromIgnoreList(List<string> files, string ignoreFilePath, string basePath)
        {
            var ignorePatterns = new List<string>();
            if (!string.IsNullOrEmpty(ignoreFilePath) && File.Exists(ignoreFilePath))
            {
                ignorePatterns = File.ReadAllLines(ignoreFilePath)
                    .Where(line => !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                    .Select(line => line.Trim().Replace('/', Path.DirectorySeparatorChar))
                    .ToList();
            }

            var filteredFiles = files.Where(file =>
            {
                if (!File.Exists(file))
                {
                    return false;
                }

                string relativePath = Path.GetRelativePath(basePath, file);
                bool shouldInclude = !ignorePatterns.Any(pattern =>
                {
                    bool match = relativePath.StartsWith(pattern, StringComparison.OrdinalIgnoreCase) ||
                                 Path.GetFileName(relativePath).Equals(pattern, StringComparison.OrdinalIgnoreCase);

                    return match;
                });

                return shouldInclude;
            }).ToList();

            return filteredFiles;
        }

        public void ScanSelectedFiles(
            List<string> selectedFiles,
            List<string> allFilesInFileList,
            string outputFolderPath,
            int maxWords,
            string basePath,
            bool includeFileStructure,
            bool includeAllFilesInHierarchy)
        {
            // Map selected files to a HashSet for quick lookup
            var selectedFilesSet = new HashSet<string>(selectedFiles.Select(f => Path.GetFullPath(f)));

            // Prepare file contents for selected files
            var fileContents = new Dictionary<string, string>();

            foreach (string file in selectedFiles)
            {
                if (File.Exists(file))
                {
                    string content = File.ReadAllText(file);
                    fileContents.Add(file, content);
                }
            }

            // Build the folder hierarchy
            var filesForHierarchy = includeAllFilesInHierarchy ? allFilesInFileList : selectedFiles;

            StringBuilder currentFile = new StringBuilder();
            int wordCount = 0;
            int fileCount = 1;
            var currentFileNames = new List<string>();

            if (includeFileStructure)
            {
                currentFile.AppendLine("**File Structure/Hierarchy**");
                currentFile.AppendLine();
                var tree = GetDirectoryTree(basePath, filesForHierarchy);
                currentFile.AppendLine(tree);
                currentFile.AppendLine();
            }

            foreach (var file in fileContents)
            {
                currentFile.AppendLine($"***{Path.GetFileName(file.Key)}***");

                string[] lines = file.Value.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                foreach (string line in lines)
                {
                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;

                    currentFile.AppendLine(line);

                    if (wordCount >= maxWords)
                    {
                        string textFileName = string.Join("_", currentFileNames.Select(GetSafeFileName));
                        string uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                        while (File.Exists(Path.Combine(outputFolderPath, uniqueFileName)))
                        {
                            fileCount++;
                            uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                        }
                        File.WriteAllText(Path.Combine(outputFolderPath, uniqueFileName), currentFile.ToString());

                        currentFile.Clear();
                        currentFileNames.Clear();
                        wordCount = 0;
                        fileCount++;
                    }
                }

                currentFile.AppendLine();
                currentFileNames.Add(Path.GetFileName(file.Key));
            }

            if (currentFile.Length > 0)
            {
                string textFileName = string.Join("_", currentFileNames.Select(GetSafeFileName));
                string uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                while (File.Exists(Path.Combine(outputFolderPath, uniqueFileName)))
                {
                    fileCount++;
                    uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                }
                File.WriteAllText(Path.Combine(outputFolderPath, uniqueFileName), currentFile.ToString());
            }
        }

        private string GetSafeFileName(string fileName)
        {
            string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            string safeFileName = new string(fileName.Select(c => invalidChars.Contains(c) ? '_' : c).ToArray());
            return safeFileName.Substring(0, Math.Min(safeFileName.Length, 50));
        }

        private string GetDirectoryTree(string rootPath, List<string> includedFiles)
        {
            var sb = new StringBuilder();
            var rootDir = new DirectoryInfo(rootPath);
            var includedFilesSet = new HashSet<string>(includedFiles.Select(f => Path.GetFullPath(f)));

            BuildDirectoryTree(sb, rootDir, "", true, includedFilesSet);
            return sb.ToString();
        }

        private void BuildDirectoryTree(StringBuilder sb, DirectoryInfo dir, string indent, bool last, HashSet<string> includedFiles)
        {
            if (!HasIncludedFiles(dir.FullName, includedFiles))
            {
                return;
            }

            sb.Append(indent);
            if (last)
            {
                sb.Append("└── ");
                indent += "    ";
            }
            else
            {
                sb.Append("├── ");
                indent += "│   ";
            }
            sb.AppendLine(dir.Name);

            var entries = dir.GetFileSystemInfos()
                .Where(e => e is DirectoryInfo ? HasIncludedFiles(e.FullName, includedFiles) : includedFiles.Contains(e.FullName))
                .OrderBy(e => e is FileInfo)
                .ToList();

            for (int i = 0; i < entries.Count; i++)
            {
                bool isLast = (i == entries.Count - 1);

                if (entries[i] is DirectoryInfo subDir)
                {
                    BuildDirectoryTree(sb, subDir, indent, isLast, includedFiles);
                }
                else if (entries[i] is FileInfo file)
                {
                    sb.Append(indent);
                    sb.Append(isLast ? "└── " : "├── ");
                    sb.AppendLine(file.Name);
                }
            }
        }

        private bool HasIncludedFiles(string directoryPath, HashSet<string> includedFiles)
        {
            return includedFiles.Any(file => file.StartsWith(directoryPath, StringComparison.OrdinalIgnoreCase));
        }
    }
}
