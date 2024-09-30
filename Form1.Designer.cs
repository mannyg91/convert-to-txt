using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CodeToTxt
{
    partial class Form1
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Declare all controls
        private System.Windows.Forms.CheckBox chkHtml;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.CheckBox chkCshtml;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.NumericUpDown nudMaxWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIgnoreFilePath;
        private System.Windows.Forms.Button btnBrowseIgnore;
        private System.Windows.Forms.CheckedListBox fileListBox;

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
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.chkCshtml = new System.Windows.Forms.CheckBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.nudMaxWords = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIgnoreFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseIgnore = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWords)).BeginInit();
            this.SuspendLayout();
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Checked = true;
            this.chkHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHtml.Location = new System.Drawing.Point(323, 199);
            this.chkHtml.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(100, 36);
            this.chkHtml.TabIndex = 0;
            this.chkHtml.Text = ".html";
            this.chkHtml.UseVisualStyleBackColor = true;
            this.chkHtml.CheckedChanged += new System.EventHandler(this.chkHtml_CheckedChanged);
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Checked = true;
            this.chkCss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCss.Location = new System.Drawing.Point(424, 199);
            this.chkCss.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(82, 36);
            this.chkCss.TabIndex = 1;
            this.chkCss.Text = ".css";
            this.chkCss.UseVisualStyleBackColor = true;
            this.chkCss.CheckedChanged += new System.EventHandler(this.chkHtml_CheckedChanged);
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Checked = true;
            this.chkJs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJs.Location = new System.Drawing.Point(514, 199);
            this.chkJs.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(67, 36);
            this.chkJs.TabIndex = 2;
            this.chkJs.Text = ".js";
            this.chkJs.UseVisualStyleBackColor = true;
            this.chkJs.CheckedChanged += new System.EventHandler(this.chkHtml_CheckedChanged);
            // 
            // chkCshtml
            // 
            this.chkCshtml.AutoSize = true;
            this.chkCshtml.Checked = true;
            this.chkCshtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCshtml.Location = new System.Drawing.Point(785, 199);
            this.chkCshtml.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkCshtml.Name = "chkCshtml";
            this.chkCshtml.Size = new System.Drawing.Size(121, 36);
            this.chkCshtml.TabIndex = 20;
            this.chkCshtml.Text = ".cshtml";
            this.chkCshtml.UseVisualStyleBackColor = true;
            this.chkCshtml.CheckedChanged += new System.EventHandler(this.chkHtml_CheckedChanged);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(977, 275);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(162, 57);
            this.btnBrowseFolder.TabIndex = 3;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(320, 284);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(645, 39);
            this.txtFolderPath.TabIndex = 4;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(977, 346);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(162, 57);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(320, 355);
            this.txtOutputPath.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(645, 39);
            this.txtOutputPath.TabIndex = 6;
            // 
            // nudMaxWords
            // 
            this.nudMaxWords.Location = new System.Drawing.Point(577, 813);
            this.nudMaxWords.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.nudMaxWords.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.nudMaxWords.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudMaxWords.Name = "nudMaxWords";
            this.nudMaxWords.Size = new System.Drawing.Size(181, 39);
            this.nudMaxWords.TabIndex = 7;
            this.nudMaxWords.Value = new decimal(new int[] { 50000, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(367, 813);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Max Words/File:";
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScan.Location = new System.Drawing.Point(825, 801);
            this.btnScan.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(227, 57);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Scan / Generate";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Target File Types:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "Code-to-TXTs";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(320, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(891, 155);
            this.label4.TabIndex = 12;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(135, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Source Folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(78, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destination Folder:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(601, 199);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 36);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = ".cs";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.chkHtml_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(692, 199);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 36);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = ".py";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(168, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ignore .txt:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIgnoreFilePath
            // 
            this.txtIgnoreFilePath.Location = new System.Drawing.Point(321, 426);
            this.txtIgnoreFilePath.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtIgnoreFilePath.Name = "txtIgnoreFilePath";
            this.txtIgnoreFilePath.ReadOnly = true;
            this.txtIgnoreFilePath.Size = new System.Drawing.Size(645, 39);
            this.txtIgnoreFilePath.TabIndex = 18;
            // 
            // btnBrowseIgnore
            // 
            this.btnBrowseIgnore.Location = new System.Drawing.Point(978, 417);
            this.btnBrowseIgnore.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBrowseIgnore.Name = "btnBrowseIgnore";
            this.btnBrowseIgnore.Size = new System.Drawing.Size(162, 57);
            this.btnBrowseIgnore.TabIndex = 17;
            this.btnBrowseIgnore.Text = "Browse";
            this.btnBrowseIgnore.UseVisualStyleBackColor = true;
            this.btnBrowseIgnore.Click += new System.EventHandler(this.btnBrowseIgnore_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListBox.CheckOnClick = true;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(50, 500);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(1200, 200);
            this.fileListBox.TabIndex = 21;
            this.fileListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FileListBox_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 932);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIgnoreFilePath);
            this.Controls.Add(this.btnBrowseIgnore);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMaxWords);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.chkJs);
            this.Controls.Add(this.chkCss);
            this.Controls.Add(this.chkHtml);
            this.Controls.Add(this.chkCshtml);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Code to Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
