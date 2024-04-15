﻿using System;
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label7 = new Label();
            txtIgnoreFilePath = new TextBox();
            btnBrowseIgnore = new Button();
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
            chkHtml.Size = new Size(100, 36);
            chkHtml.TabIndex = 0;
            chkHtml.Text = ".html";
            chkHtml.UseVisualStyleBackColor = true;
            chkHtml.CheckedChanged += chkHtml_CheckedChanged;
            // 
            // chkCss
            // 
            chkCss.AutoSize = true;
            chkCss.Checked = true;
            chkCss.CheckState = CheckState.Checked;
            chkCss.Location = new Point(417, 156);
            chkCss.Margin = new Padding(6, 7, 6, 7);
            chkCss.Name = "chkCss";
            chkCss.Size = new Size(82, 36);
            chkCss.TabIndex = 1;
            chkCss.Text = ".css";
            chkCss.UseVisualStyleBackColor = true;
            // 
            // chkJs
            // 
            chkJs.AutoSize = true;
            chkJs.Checked = true;
            chkJs.CheckState = CheckState.Checked;
            chkJs.Location = new Point(507, 156);
            chkJs.Margin = new Padding(6, 7, 6, 7);
            chkJs.Name = "chkJs";
            chkJs.Size = new Size(67, 36);
            chkJs.TabIndex = 2;
            chkJs.Text = ".js";
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
            nudMaxWords.Location = new Point(583, 502);
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
            label1.Location = new Point(373, 502);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 8;
            label1.Text = "Max Words/File:";
            // 
            // btnScan
            // 
            btnScan.BackColor = SystemColors.Highlight;
            btnScan.ForeColor = SystemColors.ButtonHighlight;
            btnScan.Location = new Point(831, 490);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(594, 156);
            checkBox1.Margin = new Padding(6, 7, 6, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 36);
            checkBox1.TabIndex = 15;
            checkBox1.Text = ".cs";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(685, 156);
            checkBox2.Margin = new Padding(6, 7, 6, 7);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 36);
            checkBox2.TabIndex = 16;
            checkBox2.Text = ".py";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(161, 388);
            label7.Name = "label7";
            label7.Size = new Size(143, 32);
            label7.TabIndex = 19;
            label7.Text = "Ignore File:";
            // 
            // txtIgnoreFilePath
            // 
            txtIgnoreFilePath.Location = new Point(314, 383);
            txtIgnoreFilePath.Margin = new Padding(6, 7, 6, 7);
            txtIgnoreFilePath.Name = "txtIgnoreFilePath";
            txtIgnoreFilePath.ReadOnly = true;
            txtIgnoreFilePath.Size = new Size(645, 39);
            txtIgnoreFilePath.TabIndex = 18;
            // 
            // btnBrowseIgnore
            // 
            btnBrowseIgnore.Location = new Point(971, 374);
            btnBrowseIgnore.Margin = new Padding(6, 7, 6, 7);
            btnBrowseIgnore.Name = "btnBrowseIgnore";
            btnBrowseIgnore.Size = new Size(162, 57);
            btnBrowseIgnore.TabIndex = 17;
            btnBrowseIgnore.Text = "Browse";
            btnBrowseIgnore.UseVisualStyleBackColor = true;
            btnBrowseIgnore.Click += btnBrowseIgnore_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 587);
            Controls.Add(label7);
            Controls.Add(txtIgnoreFilePath);
            Controls.Add(btnBrowseIgnore);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
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
            Load += Form1_Load;
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
    }
}