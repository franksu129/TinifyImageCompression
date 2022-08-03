
namespace TinifyImageCompression
{
    partial class FormTinypng
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompression = new System.Windows.Forms.Button();
            this.txtImageFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog_image = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCompression
            // 
            this.btnCompression.Location = new System.Drawing.Point(12, 43);
            this.btnCompression.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompression.Name = "btnCompression";
            this.btnCompression.Size = new System.Drawing.Size(145, 25);
            this.btnCompression.TabIndex = 0;
            this.btnCompression.Text = "Compression";
            this.btnCompression.UseVisualStyleBackColor = true;
            this.btnCompression.Click += new System.EventHandler(this.btnCompression_Click);
            // 
            // txtImageFolder
            // 
            this.txtImageFolder.Location = new System.Drawing.Point(87, 13);
            this.txtImageFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtImageFolder.Name = "txtImageFolder";
            this.txtImageFolder.ReadOnly = true;
            this.txtImageFolder.Size = new System.Drawing.Size(494, 23);
            this.txtImageFolder.TabIndex = 1;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(585, 13);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(31, 23);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder Path:";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(396, 43);
            this.btnCount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(99, 25);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(509, 48);
            this.labCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(107, 15);
            this.labCount.TabIndex = 5;
            this.labCount.Text = "ApiTotalCount - 0";
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.HorizontalScrollbar = true;
            this.lstBox.ItemHeight = 15;
            this.lstBox.Location = new System.Drawing.Point(12, 73);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(623, 274);
            this.lstBox.TabIndex = 7;
            // 
            // FormTinypng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 356);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.txtImageFolder);
            this.Controls.Add(this.btnCompression);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTinypng";
            this.Text = "Image Compression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompression;
        private System.Windows.Forms.TextBox txtImageFolder;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_image;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.ListBox lstBox;
    }
}

