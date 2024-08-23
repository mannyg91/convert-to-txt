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
        private List<string> selectedFiles = new List<string>();
        private CheckedListBox fileListBox;

        public Form1()
        {
            InitializeComponent();
            InitializeFileListBox();
            codeScanner = new CodeScanner();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void InitializeFileListBox()
        {
            fileListBox = new CheckedListBox
            {
                Location = new Point(320, 450),
                Size = new Size(645, 200),
                CheckOnClick = true
            };
            this.Controls.Add(fileListBox);

            // Adjust the form size to accommodate the new control
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height + 220);

            // Move the Scan button and Max Words controls
            btnScan.Location = new Point(btnScan.Location.X, btnScan.Location.Y + 220);
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 220);
            nudMaxWords.Location = new Point(nudMaxWords.Location.X, nudMaxWords.Location.Y + 220);
        }

        private void FileListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string filePath = fileListBox.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                if (!selectedFiles.Contains(filePath))
                    selectedFiles.Add(filePath);
            }
            else
            {
                selectedFiles.Remove(filePath);
            }
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
            if (checkBox1.Checked) allowedExtensions.Add(".cs");
            if (checkBox2.Checked) allowedExtensions.Add(".py");
            if (chkCshtml.Checked) allowedExtensions.Add(".cshtml");

            var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                .Where(file => allowedExtensions.Contains(Path.GetExtension(file).ToLower()))
                .ToList();

            foreach (var file in files)
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

            var selectedFiles = fileListBox.CheckedItems.Cast<string>().ToList();

            if (selectedFiles.Count == 0)
            {
                MessageBox.Show("Please select at least one file to process.");
                return;
            }

            if (!string.IsNullOrEmpty(outputFolderPath) && Directory.Exists(outputFolderPath))
            {
                codeScanner.ScanSelectedFiles(selectedFiles, outputFolderPath, maxWords, ignoreFilePath);
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

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save paths
            Properties.Settings.Default[FolderPathKey] = txtFolderPath.Text;
            Properties.Settings.Default[OutputPathKey] = txtOutputPath.Text;
            Properties.Settings.Default[IgnoreFilePathKey] = txtIgnoreFilePath.Text;
            Properties.Settings.Default.Save();
        }
    }
}