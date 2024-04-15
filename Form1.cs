using CodeToTxt;
using System;
using System.Windows.Forms;

namespace CodeToTxt
{
    public partial class Form1 : Form
    {
        private CodeScanner codeScanner;

        public Form1()
        {
            InitializeComponent();
            codeScanner = new CodeScanner();
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

            if (!string.IsNullOrEmpty(folderPath) && !string.IsNullOrEmpty(outputFolderPath))
            {
                if (Directory.Exists(outputFolderPath))
                {
                    codeScanner.ScanFolder(folderPath, outputFolderPath, maxWords, scanHtml, scanCss, scanJs);
                    MessageBox.Show("Scanning completed successfully!");
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
    }
}