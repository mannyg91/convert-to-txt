﻿using System;
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
        private CheckBox chkCs;
        private CheckBox chkPy;
        private Label label7;
        private TextBox txtIgnoreFilePath;
        private Button btnBrowseIgnore;
        private CustomCheckedListBox fileListBox; // Use the custom control
        private Panel topPanel;
        private Panel bottomPanel;
        private Button btnSelectAll;
        private Button btnDeselectAll;
        private CheckBox chkIncludeFileStructure;
        private CheckBox chkIncludeAllFiles;
        private Label labelCustomTypes;
        private TextBox txtCustomFileTypes;

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

            // Initialize panels
            this.topPanel = new Panel();
            this.bottomPanel = new Panel();

            // Initialize controls
            this.chkHtml = new CheckBox();
            this.chkCss = new CheckBox();
            this.chkJs = new CheckBox();
            this.chkCshtml = new CheckBox();
            this.chkCs = new CheckBox();
            this.chkPy = new CheckBox();
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
            this.fileListBox = new CustomCheckedListBox(); // Use the custom control
            this.btnSelectAll = new Button();
            this.btnDeselectAll = new Button();
            this.chkIncludeFileStructure = new CheckBox();
            this.chkIncludeAllFiles = new CheckBox();
            this.labelCustomTypes = new Label();
            this.txtCustomFileTypes = new TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWords)).BeginInit();
            this.SuspendLayout();

            // 
            // topPanel
            // 
            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Height = 500; // Adjust the height as needed
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.chkHtml);
            this.topPanel.Controls.Add(this.chkCss);
            this.topPanel.Controls.Add(this.chkJs);
            this.topPanel.Controls.Add(this.chkCs);
            this.topPanel.Controls.Add(this.chkPy);
            this.topPanel.Controls.Add(this.chkCshtml);
            this.topPanel.Controls.Add(this.labelCustomTypes);
            this.topPanel.Controls.Add(this.txtCustomFileTypes);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.txtFolderPath);
            this.topPanel.Controls.Add(this.btnBrowseFolder);
            this.topPanel.Controls.Add(this.label6);
            this.topPanel.Controls.Add(this.txtOutputPath);
            this.topPanel.Controls.Add(this.btnBrowseOutput);
            this.topPanel.Controls.Add(this.label7);
            this.topPanel.Controls.Add(this.txtIgnoreFilePath);
            this.topPanel.Controls.Add(this.btnBrowseIgnore);
            this.topPanel.Controls.Add(this.btnSelectAll);
            this.topPanel.Controls.Add(this.btnDeselectAll);
            this.topPanel.Controls.Add(this.chkIncludeFileStructure);
            this.topPanel.Controls.Add(this.chkIncludeAllFiles);

            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = DockStyle.Bottom;
            this.bottomPanel.Height = 100; // Adjust the height as needed
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
            this.fileListBox.Location = new Point(0, this.topPanel.Height);
            this.fileListBox.Margin = new Padding(6, 7, 6, 7);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new Size(1000, this.ClientSize.Height - this.topPanel.Height - this.bottomPanel.Height);
            this.fileListBox.TabIndex = 21;

            // 
            // label3 (Title)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 14F, (FontStyle.Bold | FontStyle.Underline), GraphicsUnit.Point);
            this.label3.Location = new Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new Size(266, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "Code-to-TXTs";

            // 
            // label4 (Description)
            // 
            this.label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.label4.Location = new Point(300, 20);
            this.label4.Name = "label4";
            this.label4.Size = new Size(650, 150);
            this.label4.TabIndex = 12;
            this.label4.Text = "This application allows you to scan code files and generate text files with the content. You can select specific file types, include the folder hierarchy, and choose to include all files or only selected ones.";
            this.label4.Click += new EventHandler(this.label4_Click);

            // 
            // label2 (Target File Types)
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = FlatStyle.System;
            this.label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.Location = new Point(20, 190);
            this.label2.Name = "label2";
            this.label2.Size = new Size(211, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Target File Types:";

            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Checked = true;
            this.chkHtml.CheckState = CheckState.Checked;
            this.chkHtml.Location = new Point(240, 190);
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
            this.chkCss.Location = new Point(350, 190);
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
            this.chkJs.Location = new Point(440, 190);
            this.chkJs.Margin = new Padding(6, 7, 6, 7);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new Size(67, 36);
            this.chkJs.TabIndex = 2;
            this.chkJs.Text = ".js";
            this.chkJs.UseVisualStyleBackColor = true;
            this.chkJs.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // chkCs (.cs)
            // 
            this.chkCs.AutoSize = true;
            this.chkCs.Checked = true;
            this.chkCs.CheckState = CheckState.Checked;
            this.chkCs.Location = new Point(520, 190);
            this.chkCs.Margin = new Padding(6, 7, 6, 7);
            this.chkCs.Name = "chkCs";
            this.chkCs.Size = new Size(72, 36);
            this.chkCs.TabIndex = 15;
            this.chkCs.Text = ".cs";
            this.chkCs.UseVisualStyleBackColor = true;
            this.chkCs.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // chkPy (.py)
            // 
            this.chkPy.AutoSize = true;
            this.chkPy.Checked = true;
            this.chkPy.CheckState = CheckState.Checked;
            this.chkPy.Location = new Point(600, 190);
            this.chkPy.Margin = new Padding(6, 7, 6, 7);
            this.chkPy.Name = "chkPy";
            this.chkPy.Size = new Size(77, 36);
            this.chkPy.TabIndex = 16;
            this.chkPy.Text = ".py";
            this.chkPy.UseVisualStyleBackColor = true;
            this.chkPy.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // chkCshtml
            // 
            this.chkCshtml.AutoSize = true;
            this.chkCshtml.Checked = true;
            this.chkCshtml.CheckState = CheckState.Checked;
            this.chkCshtml.Location = new Point(690, 190);
            this.chkCshtml.Margin = new Padding(6, 7, 6, 7);
            this.chkCshtml.Name = "chkCshtml";
            this.chkCshtml.Size = new Size(121, 36);
            this.chkCshtml.TabIndex = 20;
            this.chkCshtml.Text = ".cshtml";
            this.chkCshtml.UseVisualStyleBackColor = true;
            this.chkCshtml.CheckedChanged += new EventHandler(this.chkHtml_CheckedChanged);

            // 
            // labelCustomTypes
            // 
            this.labelCustomTypes.AutoSize = true;
            this.labelCustomTypes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelCustomTypes.Location = new Point(20, 240);
            this.labelCustomTypes.Name = "labelCustomTypes";
            this.labelCustomTypes.Size = new Size(220, 32);
            this.labelCustomTypes.TabIndex = 21;
            this.labelCustomTypes.Text = "Custom File Types:";

            // 
            // txtCustomFileTypes
            // 
            this.txtCustomFileTypes.Location = new Point(250, 240);
            this.txtCustomFileTypes.Margin = new Padding(6, 7, 6, 7);
            this.txtCustomFileTypes.Name = "txtCustomFileTypes";
            this.txtCustomFileTypes.Size = new Size(300, 39);
            this.txtCustomFileTypes.TabIndex = 22;
            this.txtCustomFileTypes.TextChanged += new EventHandler(this.txtCustomFileTypes_TextChanged);

            // Adjust positions of other controls accordingly (move them down if necessary)
            // For example:
            this.label5.Location = new Point(20, 290);
            this.txtFolderPath.Location = new Point(210, 290);
            this.btnBrowseFolder.Location = new Point(870, 280);

            this.label6.Location = new Point(20, 350);
            this.txtOutputPath.Location = new Point(260, 350);
            this.btnBrowseOutput.Location = new Point(910, 340);

            this.label7.Location = new Point(20, 410);
            this.txtIgnoreFilePath.Location = new Point(170, 410);
            this.btnBrowseIgnore.Location = new Point(830, 400);

            this.btnSelectAll.Location = new Point(20, 470);
            this.btnDeselectAll.Location = new Point(180, 470);

            this.chkIncludeFileStructure.Location = new Point(350, 470);
            this.chkIncludeAllFiles.Location = new Point(700, 470);

            // 
            // label5 (Source Folder)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label5.Location = new Point(20, 290);
            this.label5.Name = "label5";
            this.label5.Size = new Size(179, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Source Folder:";

            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new Point(210, 290);
            this.txtFolderPath.Margin = new Padding(6, 7, 6, 7);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new Size(645, 39);
            this.txtFolderPath.TabIndex = 4;

            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new Point(870, 280);
            this.btnBrowseFolder.Margin = new Padding(6, 7, 6, 7);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new Size(162, 57);
            this.btnBrowseFolder.TabIndex = 3;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new EventHandler(this.btnBrowseFolder_Click);

            // 
            // label6 (Destination Folder)
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label6.Location = new Point(20, 350);
            this.label6.Name = "label6";
            this.label6.Size = new Size(233, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destination Folder:";

            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new Point(260, 350);
            this.txtOutputPath.Margin = new Padding(6, 7, 6, 7);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new Size(645, 39);
            this.txtOutputPath.TabIndex = 6;

            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new Point(910, 340);
            this.btnBrowseOutput.Margin = new Padding(6, 7, 6, 7);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new Size(162, 57);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new EventHandler(this.btnBrowseOutput_Click);

            // 
            // label7 (Ignore .txt)
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label7.Location = new Point(20, 410);
            this.label7.Name = "label7";
            this.label7.Size = new Size(142, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ignore .txt:";
            this.label7.Click += new EventHandler(this.label7_Click);

            // 
            // txtIgnoreFilePath
            // 
            this.txtIgnoreFilePath.Location = new Point(170, 410);
            this.txtIgnoreFilePath.Margin = new Padding(6, 7, 6, 7);
            this.txtIgnoreFilePath.Name = "txtIgnoreFilePath";
            this.txtIgnoreFilePath.ReadOnly = true;
            this.txtIgnoreFilePath.Size = new Size(645, 39);
            this.txtIgnoreFilePath.TabIndex = 18;

            // 
            // btnBrowseIgnore
            // 
            this.btnBrowseIgnore.Location = new Point(830, 400);
            this.btnBrowseIgnore.Margin = new Padding(6, 7, 6, 7);
            this.btnBrowseIgnore.Name = "btnBrowseIgnore";
            this.btnBrowseIgnore.Size = new Size(162, 57);
            this.btnBrowseIgnore.TabIndex = 17;
            this.btnBrowseIgnore.Text = "Browse";
            this.btnBrowseIgnore.UseVisualStyleBackColor = true;
            this.btnBrowseIgnore.Click += new EventHandler(this.btnBrowseIgnore_Click);

            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new Point(20, 470);
            this.btnSelectAll.Margin = new Padding(6, 7, 6, 7);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new Size(150, 40);
            this.btnSelectAll.TabIndex = 22;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new EventHandler(this.btnSelectAll_Click);

            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new Point(180, 470);
            this.btnDeselectAll.Margin = new Padding(6, 7, 6, 7);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new Size(150, 40);
            this.btnDeselectAll.TabIndex = 23;
            this.btnDeselectAll.Text = "Deselect All";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new EventHandler(this.btnDeselectAll_Click);

            // 
            // chkIncludeFileStructure
            // 
            this.chkIncludeFileStructure.AutoSize = true;
            this.chkIncludeFileStructure.Location = new Point(350, 470);
            this.chkIncludeFileStructure.Margin = new Padding(6, 7, 6, 7);
            this.chkIncludeFileStructure.Name = "chkIncludeFileStructure";
            this.chkIncludeFileStructure.Size = new Size(327, 36);
            this.chkIncludeFileStructure.TabIndex = 24;
            this.chkIncludeFileStructure.Text = "Include Folder Hierarchy";
            this.chkIncludeFileStructure.UseVisualStyleBackColor = true;

            // 
            // chkIncludeAllFiles
            // 
            this.chkIncludeAllFiles.AutoSize = true;
            this.chkIncludeAllFiles.Checked = true;
            this.chkIncludeAllFiles.CheckState = CheckState.Checked;
            this.chkIncludeAllFiles.Location = new Point(700, 470);
            this.chkIncludeAllFiles.Margin = new Padding(6, 7, 6, 7);
            this.chkIncludeAllFiles.Name = "chkIncludeAllFiles";
            this.chkIncludeAllFiles.Size = new Size(390, 36);
            this.chkIncludeAllFiles.TabIndex = 25;
            this.chkIncludeAllFiles.Text = "Include All Files in Folder Hierarchy";
            this.chkIncludeAllFiles.UseVisualStyleBackColor = true;

            // 
            // bottomPanel controls
            // 

            // 
            // label1 (Max Words/File)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(20, 30);
            this.label1.Margin = new Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(201, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Max Words/File:";

            // 
            // nudMaxWords
            // 
            this.nudMaxWords.Location = new Point(230, 30);
            this.nudMaxWords.Margin = new Padding(6, 7, 6, 7);
            this.nudMaxWords.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudMaxWords.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudMaxWords.Name = "nudMaxWords";
            this.nudMaxWords.Size = new Size(181, 39);
            this.nudMaxWords.TabIndex = 7;
            this.nudMaxWords.Value = new decimal(new int[] { 50000, 0, 0, 0 });

            // 
            // btnScan
            // 
            this.btnScan.BackColor = SystemColors.Highlight;
            this.btnScan.ForeColor = SystemColors.ButtonHighlight;
            this.btnScan.Location = new Point(450, 20);
            this.btnScan.Margin = new Padding(6, 7, 6, 7);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new Size(227, 57);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Scan / Generate";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new EventHandler(this.btnScan_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 800); // Adjust the size as needed
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Code to Text";
            this.Load += new EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWords)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
