using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeToTxt
{
    public partial class Form1 : Form
    {


        private void InitializeComponent()
        {
            chkHtml = new CheckBox();
            chkCss = new CheckBox();
            chkJs = new CheckBox();
            btnBrowseFolder = new Button();
            txtFolderPath = new TextBox();
            btnBrowseOutput = new Button();
            txtOutputPath = new TextBox();
            nudMaxWords = new NumericUpDown();
            label1 = new Label();
            btnScan = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMaxWords).BeginInit();
            SuspendLayout();
            // 
            // chkHtml
            // 
            chkHtml.AutoSize = true;
            chkHtml.Checked = true;
            chkHtml.CheckState = CheckState.Checked;
            chkHtml.Location = new Point(316, 156);
            chkHtml.Margin = new Padding(6, 7, 6, 7);
            chkHtml.Name = "chkHtml";
            chkHtml.Size = new Size(109, 36);
            chkHtml.TabIndex = 0;
            chkHtml.Text = "HTML";
            chkHtml.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            chkCss.AutoSize = true;
            chkCss.Checked = true;
            chkCss.CheckState = CheckState.Checked;
            chkCss.Location = new Point(448, 156);
            chkCss.Margin = new Padding(6, 7, 6, 7);
            chkCss.Name = "chkCss";
            chkCss.Size = new Size(87, 36);
            chkCss.TabIndex = 1;
            chkCss.Text = "CSS";
            chkCss.UseVisualStyleBackColor = true;
            // 
            // chkJs
            // 
            chkJs.AutoSize = true;
            chkJs.Checked = true;
            chkJs.CheckState = CheckState.Checked;
            chkJs.Location = new Point(563, 156);
            chkJs.Margin = new Padding(6, 7, 6, 7);
            chkJs.Name = "chkJs";
            chkJs.Size = new Size(68, 36);
            chkJs.TabIndex = 2;
            chkJs.Text = "JS";
            chkJs.UseVisualStyleBackColor = true;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.Location = new Point(970, 232);
            btnBrowseFolder.Margin = new Padding(6, 7, 6, 7);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(162, 57);
            btnBrowseFolder.TabIndex = 3;
            btnBrowseFolder.Text = "Browse";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            btnBrowseFolder.Click += btnBrowseFolder_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(313, 241);
            txtFolderPath.Margin = new Padding(6, 7, 6, 7);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(645, 39);
            txtFolderPath.TabIndex = 4;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Location = new Point(970, 303);
            btnBrowseOutput.Margin = new Padding(6, 7, 6, 7);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(162, 57);
            btnBrowseOutput.TabIndex = 5;
            btnBrowseOutput.Text = "Browse";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new Point(313, 312);
            txtOutputPath.Margin = new Padding(6, 7, 6, 7);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.ReadOnly = true;
            txtOutputPath.Size = new Size(645, 39);
            txtOutputPath.TabIndex = 6;
            // 
            // nudMaxWords
            // 
            nudMaxWords.Location = new Point(316, 424);
            nudMaxWords.Margin = new Padding(6, 7, 6, 7);
            nudMaxWords.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMaxWords.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxWords.Name = "nudMaxWords";
            nudMaxWords.Size = new Size(181, 39);
            nudMaxWords.TabIndex = 7;
            nudMaxWords.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 424);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 8;
            label1.Text = "Max Words/File:";
            label1.Click += label1_Click;
            // 
            // btnScan
            // 
            btnScan.BackColor = SystemColors.Highlight;
            btnScan.ForeColor = SystemColors.ButtonHighlight;
            btnScan.Location = new Point(732, 417);
            btnScan.Margin = new Padding(6, 7, 6, 7);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(227, 57);
            btnScan.TabIndex = 9;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(175, 156);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 10;
            label2.Text = "File Types:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(36, 34);
            label3.Name = "label3";
            label3.Size = new Size(237, 51);
            label3.TabIndex = 11;
            label3.Text = "Code-to-Txt";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(307, 49);
            label4.Name = "label4";
            label4.Size = new Size(825, 96);
            label4.TabIndex = 12;
            label4.Text = "Scans project files and combines code onto one or more .txt files split up by the desired amount of characters. Useful for code analysis when using LLM models.";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(128, 244);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 13;
            label5.Text = "Source Folder:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(71, 319);
            label6.Name = "label6";
            label6.Size = new Size(233, 32);
            label6.TabIndex = 14;
            label6.Text = "Destination Folder:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 525);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnScan);
            Controls.Add(label1);
            Controls.Add(nudMaxWords);
            Controls.Add(txtOutputPath);
            Controls.Add(btnBrowseOutput);
            Controls.Add(txtFolderPath);
            Controls.Add(btnBrowseFolder);
            Controls.Add(chkJs);
            Controls.Add(chkCss);
            Controls.Add(chkHtml);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Code to Text";
            ((System.ComponentModel.ISupportInitialize)nudMaxWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox chkHtml;
        private CheckBox chkCss;
        private CheckBox chkJs;
        private Button btnBrowseFolder;
        private TextBox txtFolderPath;
        private Button btnBrowseOutput;
        private TextBox txtOutputPath;
        private NumericUpDown nudMaxWords;
        private Label label1;
        private Button btnScan;

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
                    ScanFolder(folderPath, outputFolderPath, maxWords, scanHtml, scanCss, scanJs);
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

        private void ScanFolder(string folderPath, string outputFolderPath, int maxWords, bool scanHtml, bool scanCss, bool scanJs)
        {
            var fileContents = new Dictionary<string, string>();
            var fileNames = new List<string>();

            foreach (string file in Directory.EnumerateFiles(folderPath, "*", SearchOption.AllDirectories))
            {
                string extension = Path.GetExtension(file).ToLower();
                if ((scanHtml && extension == ".html") ||
                    (scanCss && extension == ".css") ||
                    (scanJs && extension == ".js"))
                {
                    string content = File.ReadAllText(file);
                    fileContents.Add(file, content);
                    fileNames.Add(Path.GetFileName(file));
                }
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}