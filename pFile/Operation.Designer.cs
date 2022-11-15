
namespace pFile
{
    partial class Operation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CopyMoveDropDown = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilesOnlyTop = new System.Windows.Forms.RadioButton();
            this.DestinationPane = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FilesInSubdirectories = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.JustEnumerate = new System.Windows.Forms.RadioButton();
            this.PrefixBox = new System.Windows.Forms.TextBox();
            this.PrefixFiles = new System.Windows.Forms.CheckBox();
            this.SuffixDuplicates = new System.Windows.Forms.RadioButton();
            this.OverwriteDuplicates = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileTypeBox = new System.Windows.Forms.TextBox();
            this.RestrictFiletype = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PerformOperation = new System.Windows.Forms.Button();
            this.FolderPrefix = new System.Windows.Forms.CheckBox();
            this.Separator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationPane)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyMoveDropDown
            // 
            this.CopyMoveDropDown.DisplayMember = "0";
            this.CopyMoveDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CopyMoveDropDown.FormattingEnabled = true;
            this.CopyMoveDropDown.Items.AddRange(new object[] {
            "Copy",
            "Move"});
            this.CopyMoveDropDown.Location = new System.Drawing.Point(70, 19);
            this.CopyMoveDropDown.MaxDropDownItems = 2;
            this.CopyMoveDropDown.Name = "CopyMoveDropDown";
            this.CopyMoveDropDown.Size = new System.Drawing.Size(149, 21);
            this.CopyMoveDropDown.TabIndex = 0;
            this.CopyMoveDropDown.ValueMember = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CopyMoveDropDown);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // FilesOnlyTop
            // 
            this.FilesOnlyTop.AutoSize = true;
            this.FilesOnlyTop.Location = new System.Drawing.Point(6, 19);
            this.FilesOnlyTop.Name = "FilesOnlyTop";
            this.FilesOnlyTop.Size = new System.Drawing.Size(139, 17);
            this.FilesOnlyTop.TabIndex = 2;
            this.FilesOnlyTop.TabStop = true;
            this.FilesOnlyTop.Text = "Only files in top directory";
            this.FilesOnlyTop.UseVisualStyleBackColor = true;
            // 
            // DestinationPane
            // 
            this.DestinationPane.Location = new System.Drawing.Point(30, 19);
            this.DestinationPane.Maximum = 1;
            this.DestinationPane.Name = "DestinationPane";
            this.DestinationPane.Size = new System.Drawing.Size(222, 45);
            this.DestinationPane.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Left Pane";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Right Pane";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilesInSubdirectories
            // 
            this.FilesInSubdirectories.AutoSize = true;
            this.FilesInSubdirectories.Location = new System.Drawing.Point(6, 42);
            this.FilesInSubdirectories.Name = "FilesInSubdirectories";
            this.FilesInSubdirectories.Size = new System.Drawing.Size(138, 17);
            this.FilesInSubdirectories.TabIndex = 8;
            this.FilesInSubdirectories.TabStop = true;
            this.FilesInSubdirectories.Text = "Files in all subdirectories";
            this.FilesInSubdirectories.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FilesOnlyTop);
            this.groupBox2.Controls.Add(this.FilesInSubdirectories);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Separator);
            this.groupBox3.Controls.Add(this.FolderPrefix);
            this.groupBox3.Controls.Add(this.JustEnumerate);
            this.groupBox3.Controls.Add(this.PrefixBox);
            this.groupBox3.Controls.Add(this.PrefixFiles);
            this.groupBox3.Controls.Add(this.SuffixDuplicates);
            this.groupBox3.Controls.Add(this.OverwriteDuplicates);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.FileTypeBox);
            this.groupBox3.Controls.Add(this.RestrictFiletype);
            this.groupBox3.Location = new System.Drawing.Point(12, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 190);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // JustEnumerate
            // 
            this.JustEnumerate.AutoSize = true;
            this.JustEnumerate.Location = new System.Drawing.Point(6, 158);
            this.JustEnumerate.Name = "JustEnumerate";
            this.JustEnumerate.Size = new System.Drawing.Size(234, 17);
            this.JustEnumerate.TabIndex = 19;
            this.JustEnumerate.TabStop = true;
            this.JustEnumerate.Text = "Don\'t save original filenames, just enumerate";
            this.JustEnumerate.UseVisualStyleBackColor = true;
            // 
            // PrefixBox
            // 
            this.PrefixBox.Location = new System.Drawing.Point(162, 43);
            this.PrefixBox.Name = "PrefixBox";
            this.PrefixBox.Size = new System.Drawing.Size(90, 20);
            this.PrefixBox.TabIndex = 18;
            this.PrefixBox.TextChanged += new System.EventHandler(this.PrefixBox_TextChanged);
            // 
            // PrefixFiles
            // 
            this.PrefixFiles.AutoSize = true;
            this.PrefixFiles.Location = new System.Drawing.Point(7, 46);
            this.PrefixFiles.Name = "PrefixFiles";
            this.PrefixFiles.Size = new System.Drawing.Size(86, 17);
            this.PrefixFiles.TabIndex = 17;
            this.PrefixFiles.Text = "Prefix all files";
            this.PrefixFiles.UseVisualStyleBackColor = true;
            // 
            // SuffixDuplicates
            // 
            this.SuffixDuplicates.AutoSize = true;
            this.SuffixDuplicates.Location = new System.Drawing.Point(6, 135);
            this.SuffixDuplicates.Name = "SuffixDuplicates";
            this.SuffixDuplicates.Size = new System.Drawing.Size(201, 17);
            this.SuffixDuplicates.TabIndex = 16;
            this.SuffixDuplicates.TabStop = true;
            this.SuffixDuplicates.Text = "Suffix duplicate files with enumeration";
            this.SuffixDuplicates.UseVisualStyleBackColor = true;
            // 
            // OverwriteDuplicates
            // 
            this.OverwriteDuplicates.AutoSize = true;
            this.OverwriteDuplicates.Location = new System.Drawing.Point(6, 112);
            this.OverwriteDuplicates.Name = "OverwriteDuplicates";
            this.OverwriteDuplicates.Size = new System.Drawing.Size(229, 17);
            this.OverwriteDuplicates.TabIndex = 15;
            this.OverwriteDuplicates.TabStop = true;
            this.OverwriteDuplicates.Text = "Overwrite duplicate files rather than rename";
            this.OverwriteDuplicates.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "If filename exists:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = ".";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileTypeBox
            // 
            this.FileTypeBox.Location = new System.Drawing.Point(162, 17);
            this.FileTypeBox.Name = "FileTypeBox";
            this.FileTypeBox.Size = new System.Drawing.Size(90, 20);
            this.FileTypeBox.TabIndex = 11;
            this.FileTypeBox.TextChanged += new System.EventHandler(this.FileTypeBox_TextChanged);
            // 
            // RestrictFiletype
            // 
            this.RestrictFiletype.AutoSize = true;
            this.RestrictFiletype.Location = new System.Drawing.Point(6, 20);
            this.RestrictFiletype.Name = "RestrictFiletype";
            this.RestrictFiletype.Size = new System.Drawing.Size(110, 17);
            this.RestrictFiletype.TabIndex = 10;
            this.RestrictFiletype.Text = "Restrict to filetype";
            this.RestrictFiletype.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.DestinationPane);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(13, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 78);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Left Pane";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformOperation
            // 
            this.PerformOperation.Location = new System.Drawing.Point(107, 436);
            this.PerformOperation.Name = "PerformOperation";
            this.PerformOperation.Size = new System.Drawing.Size(75, 23);
            this.PerformOperation.TabIndex = 13;
            this.PerformOperation.Text = "OK";
            this.PerformOperation.UseVisualStyleBackColor = true;
            this.PerformOperation.Click += new System.EventHandler(this.PerformOperation_Click);
            // 
            // FolderPrefix
            // 
            this.FolderPrefix.AutoSize = true;
            this.FolderPrefix.Location = new System.Drawing.Point(6, 71);
            this.FolderPrefix.Name = "FolderPrefix";
            this.FolderPrefix.Size = new System.Drawing.Size(132, 17);
            this.FolderPrefix.TabIndex = 20;
            this.FolderPrefix.Text = "Prefix with folder name";
            this.FolderPrefix.UseVisualStyleBackColor = true;
            // 
            // Separator
            // 
            this.Separator.Location = new System.Drawing.Point(162, 69);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(90, 20);
            this.Separator.TabIndex = 21;
            this.Separator.TextChanged += new System.EventHandler(this.Separator_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(177, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "(Separator)";
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 471);
            this.Controls.Add(this.PerformOperation);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Operation";
            this.Text = "Perform Operation";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationPane)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CopyMoveDropDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FilesOnlyTop;
        private System.Windows.Forms.TrackBar DestinationPane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton FilesInSubdirectories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FileTypeBox;
        private System.Windows.Forms.CheckBox RestrictFiletype;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton JustEnumerate;
        private System.Windows.Forms.TextBox PrefixBox;
        private System.Windows.Forms.CheckBox PrefixFiles;
        private System.Windows.Forms.RadioButton SuffixDuplicates;
        private System.Windows.Forms.RadioButton OverwriteDuplicates;
        private System.Windows.Forms.Button PerformOperation;
        private System.Windows.Forms.CheckBox FolderPrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Separator;
    }
}