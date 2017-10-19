namespace SZS_Tool {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.compressBtn = new System.Windows.Forms.Button();
            this.decompressBtn = new System.Windows.Forms.Button();
            this.openZIPDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openSZSDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSZSDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // compressBtn
            // 
            this.compressBtn.Location = new System.Drawing.Point(12, 12);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(260, 110);
            this.compressBtn.TabIndex = 0;
            this.compressBtn.Text = "Compress";
            this.compressBtn.UseVisualStyleBackColor = true;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // decompressBtn
            // 
            this.decompressBtn.Location = new System.Drawing.Point(12, 128);
            this.decompressBtn.Name = "decompressBtn";
            this.decompressBtn.Size = new System.Drawing.Size(260, 110);
            this.decompressBtn.TabIndex = 0;
            this.decompressBtn.Text = "Decompress";
            this.decompressBtn.UseVisualStyleBackColor = true;
            this.decompressBtn.Click += new System.EventHandler(this.decompressBtn_Click);
            // 
            // openZIPDialog
            // 
            this.openZIPDialog.Filter = "ZIP Archives|*.zip|All Files|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Works with 3DS games (namely Super Mario 3D Land)";
            // 
            // openSZSDialog
            // 
            this.openSZSDialog.Filter = "SZS Files|*.szs|All Files|*.*";
            // 
            // saveSZSDialog
            // 
            this.saveSZSDialog.Filter = "SZS Files|*.szs|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decompressBtn);
            this.Controls.Add(this.compressBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SZS Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.Button decompressBtn;
        private System.Windows.Forms.OpenFileDialog openZIPDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openSZSDialog;
        private System.Windows.Forms.SaveFileDialog saveSZSDialog;
    }
}

