using System;
using System.Windows.Forms;
using System.Drawing;

namespace CodeToTxt
{
    partial class Form1
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Declare controls
        private CheckBox chkHtml;
        private CheckBox chkCss;
        private CheckBox chkJs;
        private CheckBox chkCshtml;
        private Button btnBrowseFolder;
        private TextBox txtFolderPath;
        private Button btnBrowseOutput;
        private TextBox txtOutputPath;
        private NumericUpDown nudMaxWords;
        private Label label1;
        private Button btnScan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label7;
        private TextBox txtIgnoreFilePath;
        private Button btnBrowseIgnore;
        private CheckedListBox fileListBox;
        private Panel topPanel;
        private Panel bottomPanel;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                fileListBox.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            // Initialize panels
            this.topPanel = new Panel();
            this.bottomPanel = new Panel();

            // Initialize controls
            this.chkHtml = new CheckBox();
            this.chkCss = new CheckBox();
            this.chkJs = new CheckBox();
            this.chkCshtml = new CheckBox();
            this.checkBox1 = new CheckBox();
            this.checkBox2 = new CheckBox();
            this.btnBrowseFolder = new Button();
            this.txtFolderPath = new TextBox();
            this.btnBrowseOutput = new Button();
            this.txtOutputPath = new TextBox();
            this.btnBrowseIgnore = new Button();
            this.txtIgnoreFilePath = new TextBox();
            this.nudMaxWords = new NumericUpDown();
            this.label1 = new Label();
            this.btnScan = new Button();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.fileListBox = new CheckedListBox();

            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWords)).BeginInit();
            this.SuspendLayout();

            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.chkHtml);
            this.topPanel.Controls.Add(this.chkCss);
            this.topPanel.Controls.Add(this.chkJs);
            this.topPanel.Controls.Add(this.checkBox1);
            this.topPanel.Controls.Add(this.checkBox2);
            this.topPanel.Controls.Add(this.chkCshtml);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.txtFolderPath);
            this.topPanel.Controls.Add(this.btnBrowseFolder);
            this.topPanel.Controls.Add(this.label6);
            this.topPanel.Controls.Add(this.txtOutputPath);
            this.topPanel.Controls.Add(this.btnBrowseOutput);
            this.topPanel.Controls.Add(this.label7);
            this.topPanel.Controls.Add(this.txtIgnoreFilePath);
            this.topPanel.Controls.Add(this.btnBrowseIgnore);

            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.bottomPanel.Dock = DockStyle.Bottom;
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.nudMaxWords);
            this.bottomPanel.Controls.Add(this.btnScan);

            // 
            // fileListBox
            // 
            this.fileListBox.CheckOnClick = true;
            this.fileListBox.Dock = DockStyle.Fill;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ItemHeight = 32;
            this.fileListBox.Location = new Point(0, 0);
            this.fileListBox.Margin = new Padding(6, 7, 6, 7);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new Size(1292, 932);
            this.fileListBox.TabIndex = 21;
            this.fileListBox.ItemCheck += new ItemCheckEventHandler(this.FileListBox_ItemCheck);

            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Checked = true;
            this.chkHtml.CheckState = CheckState.Checked;
            this.chkHtml.Location = new Point(323, 199);
            this.chkHtml.Margin = new Padding(6, 7, 6, 7);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new Size(100, 36);
            this.chkHtml.TabIndex = 0;
            this.chkHtml.Text = ".html";
            this.chkHtml.UseVisualStyleBackColor = true;
            this.chkHtml.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Checked = true;
            this.chkCss.CheckState = CheckState.Checked;
            this.chkCss.Location = new Point(424, 199);
            this.chkCss.Margin = new Padding(6, 7, 6, 7);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new Size(82, 36);
            this.chkCss.TabIndex = 1;
            this.chkCss.Text = ".css";
            this.chkCss.UseVisualStyleBackColor = true;
            this.chkCss.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Checked = true;
            this.chkJs.CheckState = CheckState.Checked;
            this.chkJs.Location = new Point(514, 199);
            this.chkJs.Margin = new Padding(6, 7, 6, 7);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new Size(67, 36);
            this.chkJs.TabIndex = 2;
            this.chkJs.Text = ".js";
            this.chkJs.UseVisualStyleBackColor = true;
            this.chkJs.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // chkCshtml
            // 
            this.chkCshtml.AutoSize = true;
            this.chkCshtml.Checked = true;
            this.chkCshtml.CheckState = CheckState.Checked;
            this.chkCshtml.Location = new Point(785, 199);
            this.chkCshtml.Margin = new Padding(6, 7, 6, 7);
            this.chkCshtml.Name = "chkCshtml";
            this.chkCshtml.Size = new Size(121, 36);
            this.chkCshtml.TabIndex = 20;
            this.chkCshtml.Text = ".cshtml";
            this.chkCshtml.UseVisualStyleBackColor = true;
            this.chkCshtml.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // checkBox1 (.cs)
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = CheckState.Checked;
            this.checkBox1.Location = new Point(601, 199);
            this.checkBox1.Margin = new Padding(6, 7, 6, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(72, 36);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = ".cs";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // checkBox2 (.py)
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = CheckState.Checked;
            this.checkBox2.Location = new Point(692, 199);
            this.checkBox2.Margin = new Padding(6, 7, 6, 7);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(77, 36);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = ".py";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);

            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new Point(977, 275);
            this.btnBrowseFolder.Margin = new Padding(6, 7, 6, 7);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new Size(162, 57);
            this.btnBrowseFolder.TabIndex = 3;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new EventHandler(this.btnBrowseFolder_Click);

            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new Point(320, 284);
            this.txtFolderPath.Margin = new Padding(6, 7, 6, 7);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new Size(645, 39);
            this.txtFolderPath.TabIndex = 4;

            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new Point(977, 346);
            this.btnBrowseOutput.Margin = new Padding(6, 7, 6, 7);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new Size(162, 57);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new EventHandler(this.btnBrowseOutput_Click);

            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new Point(320, 355);
            this.txtOutputPath.Margin = new Padding(6, 7, 6, 7);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new Size(645, 39);
            this.txtOutputPath.TabIndex = 6;

            // 
            // btnBrowseIgnore
            // 
            this.btnBrowseIgnore.Location = new Point(978, 417);
            this.btnBrowseIgnore.Margin = new Padding(6, 7, 6, 7);
            this.btnBrowseIgnore.Name = "btnBrowseIgnore";
            this.btnBrowseIgnore.Size = new Size(162, 57);
            this.btnBrowseIgnore.TabIndex = 17;
            this.btnBrowseIgnore.Text = "Browse";
            this.btnBrowseIgnore.UseVisualStyleBackColor = true;
            this.btnBrowseIgnore.Click += new EventHandler(this.btnBrowseIgnore_Click);

            // 
            // txtIgnoreFilePath
            // 
            this.txtIgnoreFilePath.Location = new Point(321, 426);
            this.txtIgnoreFilePath.Margin = new Padding(6, 7, 6, 7);
            this.txtIgnoreFilePath.Name = "txtIgnoreFilePath";
            this.txtIgnoreFilePath.ReadOnly = true;
            this.txtIgnoreFilePath.Size = new Size(645, 39);
            this.txtIgnoreFilePath.TabIndex = 18;

            // 
            // nudMaxWords
            // 
            this.nudMaxWords.Location = new Point(577, 20);
            this.nudMaxWords.Margin = new Padding(6, 7, 6, 7);
            this.nudMaxWords.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudMaxWords.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudMaxWords.Name = "nudMaxWords";
            this.nudMaxWords.Size = new Size(181, 39);
            this.nudMaxWords.TabIndex = 7;
            this.nudMaxWords.Value = new decimal(new int[] { 50000, 0, 0, 0 });

            // 
            // label1 (Max Words/File)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(367, 22);
            this.label1.Margin = new Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(201, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Max Words/File:";

            // 
            // btnScan
            // 
            this.btnScan.BackColor = SystemColors.Highlight;
            this.btnScan.ForeColor = SystemColors.ButtonHighlight;
            this.btnScan.Location = new Point(825, 10);
            this.btnScan.Margin = new Padding(6, 7, 6, 7);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new Size(227, 57);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Scan / Generate";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new EventHandler(this.btnScan_Click);

            // 
            // label2 (Target File Types)
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = FlatStyle.System;
            this.label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.Location = new Point(99, 199);
            this.label2.Name = "label2";
            this.label2.Size = new Size(211, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Target File Types:";

            // 
            // label3 (Title)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 14F, (FontStyle.Bold | FontStyle.Underline), GraphicsUnit.Point);
            this.label3.Location = new Point(36, 34);
            this.label3.Name = "label3";
            this.label3.Size = new Size(266, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "Code-to-TXTs";

            // 
            // label4 (Description)
            // 
            this.label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.label4.Location = new Point(320, 34);
            this.label4.Name = "label4";
            this.label4.Size = new Size(891, 155);
            this.label4.TabIndex = 12;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new EventHandler(this.label4_Click);

            // 
            // label5 (Source Folder)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label5.Location = new Point(135, 287);
            this.label5.Name = "label5";
            this.label5.Size = new Size(179, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Source Folder:";

            // 
            // label6 (Destination Folder)
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label6.Location = new Point(78, 362);
            this.label6.Name = "label6";
            this.label6.Size = new Size(233, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destination Folder:";

            // 
            // label7 (Ignore .txt)
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label7.Location = new Point(168, 431);
            this.label7.Name = "label7";
            this.label7.Size = new Size(142, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ignore .txt:";
            this.label7.Click += new EventHandler(this.label7_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1292, 932);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Code to Text";
            this.Load += new EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
