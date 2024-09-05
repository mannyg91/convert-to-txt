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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeFileListBox();
            codeScanner = new CodeScanner();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new EventHandler(Form1_Resize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            InitializeFileListBox();
        }
        private void InitializeFileListBox()
        {
            fileListBox = new CheckedListBox
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
                CheckOnClick = true
            };
            this.Controls.Add(fileListBox);

            // Set the fileListBox position and size relative to the form
            const float listBoxTopMargin = 0.55f; // 40% from the top of the form
            const float listBoxBottomMargin = 0.1f; // 10% from the bottom of the form
            const float listBoxSideMargin = 0.02f; // 2% from each side

            int listBoxTop = (int)(this.ClientSize.Height * listBoxTopMargin);
            int listBoxBottom = (int)(this.ClientSize.Height * (1 - listBoxBottomMargin));
            int listBoxLeft = (int)(this.ClientSize.Width * listBoxSideMargin);
            int listBoxRight = (int)(this.ClientSize.Width * (1 - listBoxSideMargin));

            fileListBox.Location = new Point(listBoxLeft, listBoxTop);
            fileListBox.Size = new Size(listBoxRight - listBoxLeft, listBoxBottom - listBoxTop);

            // Adjust other controls
            btnScan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudMaxWords.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Set positions relative to the bottom of the form
            const float bottomControlMargin = 0.05f; // 5% from the bottom
            int bottomControlY = (int)(this.ClientSize.Height * (1 - bottomControlMargin));

            btnScan.Location = new Point(listBoxRight - btnScan.Width, bottomControlY - btnScan.Height);
            label1.Location = new Point(listBoxLeft, bottomControlY - label1.Height);
            nudMaxWords.Location = new Point(label1.Right + 5, bottomControlY - nudMaxWords.Height);
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

            string ignoreFilePath = txtIgnoreFilePath.Text;
            string basePath = txtFolderPath.Text;
            var filteredFiles = codeScanner.FilterFromIgnoreList(files, ignoreFilePath, basePath);

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

            var selectedFiles = fileListBox.CheckedItems.Cast<string>().ToList();

            if (selectedFiles.Count == 0)
            {
                MessageBox.Show("Please select at least one file to process.");
                return;
            }

            if (!string.IsNullOrEmpty(outputFolderPath) && Directory.Exists(outputFolderPath))
            {
                var basePath = txtFolderPath.Text;
                codeScanner.ScanSelectedFiles(selectedFiles, outputFolderPath, maxWords, ignoreFilePath, basePath);
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