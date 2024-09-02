using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CodeToTxt
{
    public class CodeScanner
    {
        public List<string> FilterFromIgnoreList(List<string> files, string ignoreFilePath, string basePath)
        {
            Debug.WriteLine("Running filter from ignore list.");
            Debug.WriteLine($"Base path: {basePath}");
            Debug.WriteLine($"Files: {string.Join(", ", files)}");

            var ignorePatterns = new List<string>();
            if (!string.IsNullOrEmpty(ignoreFilePath) && File.Exists(ignoreFilePath))
            {
                Debug.WriteLine("Ignore file exists.");
                ignorePatterns = File.ReadAllLines(ignoreFilePath)
                    .Where(line => !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                    .Select(line => line.Trim().Replace('/', Path.DirectorySeparatorChar))
                    .ToList();
                Debug.WriteLine($"Ignore patterns: {string.Join(", ", ignorePatterns)}");
            }

            var filteredFiles = files.Where(file =>
            {
                if (!File.Exists(file))
                {
                    Debug.WriteLine($"File does not exist: {file}");
                    return false;
                }

                string relativePath = Path.GetRelativePath(basePath, file);
                bool shouldInclude = !ignorePatterns.Any(pattern =>
                {
                    bool match = relativePath.StartsWith(pattern, StringComparison.OrdinalIgnoreCase) ||
                                 Path.GetFileName(relativePath).Equals(pattern, StringComparison.OrdinalIgnoreCase);
                    if (match)
                    {
                        Debug.WriteLine($"File {file} matched ignore pattern {pattern}");
                    }
                    return match;
                });

                if (!shouldInclude)
                {
                    Debug.WriteLine($"Excluding file: {file}");
                }

                return shouldInclude;
            }).ToList();

            Debug.WriteLine($"Total files: {files.Count}");
            Debug.WriteLine($"Filtered files: {filteredFiles.Count}");
            return filteredFiles;
        }

        public void ScanSelectedFiles(List<string> selectedFiles, string outputFolderPath, int maxWords, string ignoreFilePath, string basePath)
        {
            Debug.WriteLine("scanSelectedFiles ran");
            var filteredFiles = FilterFromIgnoreList(selectedFiles, ignoreFilePath, basePath);
            var fileContents = new Dictionary<string, string>();
            var fileNames = new List<string>();

            foreach (string file in filteredFiles)
            {
                string content = File.ReadAllText(file);
                fileContents.Add(file, content);
                fileNames.Add(Path.GetFileName(file));
            }

            var textFiles = new Dictionary<string, StringBuilder>();
            var currentFile = new StringBuilder();
            var currentFileNames = new List<string>();
            int wordCount = 0;
            int fileCount = 1;

            foreach (var file in fileContents)
            {
                string[] lines = file.Value.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                currentFile.AppendLine($"***{Path.GetFileName(file.Key)}***");

                foreach (string line in lines)
                {
                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;

                    currentFile.AppendLine(line);

                    if (wordCount >= maxWords)
                    {
                        string textFileName = string.Join("_", currentFileNames.Select(GetSafeFileName));
                        string uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                        while (textFiles.ContainsKey(uniqueFileName))
                        {
                            fileCount++;
                            uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                        }
                        textFiles.Add(uniqueFileName, currentFile);

                        currentFile = new StringBuilder();
                        currentFileNames = new List<string>();
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
                while (textFiles.ContainsKey(uniqueFileName))
                {
                    fileCount++;
                    uniqueFileName = $"{GetSafeFileName(textFileName)}_{fileCount}.txt";
                }
                textFiles.Add(uniqueFileName, currentFile);
            }

            foreach (var textFile in textFiles)
            {
                string outputPath = Path.Combine(outputFolderPath, textFile.Key);
                File.WriteAllText(outputPath, textFile.Value.ToString());
            }
        }

        private string GetSafeFileName(string fileName)
        {
            string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            string safeFileName = new string(fileName.Select(c => invalidChars.Contains(c) ? '_' : c).ToArray());
            return safeFileName.Substring(0, Math.Min(safeFileName.Length, 50));
        }
    }
}