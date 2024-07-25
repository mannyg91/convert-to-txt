using CodeToTxt;
using System;
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

        public Form1()
        {
            InitializeComponent();
            codeScanner = new CodeScanner();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog.SelectedPath;
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
            string folderPath = txtFolderPath.Text;
            string outputFolderPath = txtOutputPath.Text;
            int maxWords = (int)nudMaxWords.Value;

            bool scanHtml = chkHtml.Checked;
            bool scanCss = chkCss.Checked;
            bool scanJs = chkJs.Checked;
            bool scanCs = checkBox1.Checked;
            bool scanPy = checkBox2.Checked;
            bool scanCshtml = chkCshtml.Checked;

            string ignoreFilePath = txtIgnoreFilePath.Text;

            if (!string.IsNullOrEmpty(folderPath) && !string.IsNullOrEmpty(outputFolderPath))
            {
                if (Directory.Exists(outputFolderPath))
                {
                    codeScanner.ScanFolder(folderPath, outputFolderPath, maxWords, scanHtml, scanCss, scanJs, scanCs, scanPy, scanCshtml, ignoreFilePath);
                    MessageBox.Show("Scanning completed successfully!");
                    if (Directory.Exists(outputFolderPath))
                    {
                        Process.Start("explorer.exe", outputFolderPath);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid output folder.");
                }
            }
            else
            {
                MessageBox.Show("Please select a folder and output folder.");
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