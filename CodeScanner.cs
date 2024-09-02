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