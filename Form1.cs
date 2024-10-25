using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace CodeToTxt
{
    public partial class Form1 : Form
    {
        private CodeScanner codeScanner;
        private const string FolderPathKey = "FolderPath";
        private const string OutputPathKey = "OutputPath";
        private const string IgnoreFilePathKey = "IgnoreFilePath";

        // Store the filtered files (files displayed in the file list)
        private List<string> filteredFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            codeScanner = new CodeScanner();
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void PopulateFileList()
        {
            fileListBox.Items.Clear();

            string folderPath = txtFolderPath.Text;
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
                return;

            var allowedExtensions = new List<string>();
            if (chkHtml.Checked) allowedExtensions.Add(".html");
            if (chkCss.Checked) allowedExtensions.Add(".css");
            if (chkJs.Checked) allowedExtensions.Add(".js");
            if (chkCs.Checked) allowedExtensions.Add(".cs");
            if (chkPy.Checked) allowedExtensions.Add(".py");
            if (chkCshtml.Checked) allowedExtensions.Add(".cshtml");

            var allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                .Where(file => allowedExtensions.Contains(Path.GetExtension(file).ToLower()))
                .ToList();

            string ignoreFilePath = txtIgnoreFilePath.Text;
            string basePath = txtFolderPath.Text;
            filteredFiles = codeScanner.FilterFromIgnoreList(allFiles, ignoreFilePath, basePath);

            foreach (var file in filteredFiles)
            {
                fileListBox.Items.Add(file, true);
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog.SelectedPath;
                    PopulateFileList();
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string outputFolderPath = txtOutputPath.Text;
            int maxWords = (int)nudMaxWords.Value;
            string ignoreFilePath = txtIgnoreFilePath.Text;
            bool includeFileStructure = chkIncludeFileStructure.Checked;
            bool includeAllFilesInHierarchy = chkIncludeAllFiles.Checked;

            List<string> selectedFiles = fileListBox.CheckedItems.Cast<string>().ToList();

            if (selectedFiles.Count == 0)
            {
                MessageBox.Show("Please select at least one file to process.");
                return;
            }

            if (!string.IsNullOrEmpty(outputFolderPath) && Directory.Exists(outputFolderPath))
            {
                var basePath = txtFolderPath.Text;
                codeScanner.ScanSelectedFiles(
                    selectedFiles,
                    filteredFiles, // Pass all files displayed in the file list
                    outputFolderPath,
                    maxWords,
                    basePath,
                    includeFileStructure,
                    includeAllFilesInHierarchy
                );

                MessageBox.Show("Scanning completed successfully!");
                Process.Start("explorer.exe", outputFolderPath);
            }
            else
            {
                MessageBox.Show("Please select a valid output folder.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load saved paths
            txtFolderPath.Text = Properties.Settings.Default[FolderPathKey] as string;
            txtOutputPath.Text = Properties.Settings.Default[OutputPathKey] as string;
            txtIgnoreFilePath.Text = Properties.Settings.Default[IgnoreFilePathKey] as string;
        }

        private void chkHtml_CheckedChanged(object sender, EventArgs e)
        {
            PopulateFileList();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            PopulateFileList();
        }

        private void btnBrowseIgnore_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIgnoreFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Optional: Add any action if needed
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Optional: Add any action if needed
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save paths
            Properties.Settings.Default[FolderPathKey] = txtFolderPath.Text;
            Properties.Settings.Default[OutputPathKey] = txtOutputPath.Text;
            Properties.Settings.Default[IgnoreFilePathKey] = txtIgnoreFilePath.Text;
            Properties.Settings.Default.Save();
        }

        // Event handler for Select All button
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileListBox.Items.Count; i++)
            {
                fileListBox.SetItemChecked(i, true);
            }
        }

        // Event handler for Deselect All button
        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileListBox.Items.Count; i++)
            {
                fileListBox.SetItemChecked(i, false);
            }
        }
    }
}
