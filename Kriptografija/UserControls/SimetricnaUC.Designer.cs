namespace Kriptografija.UserControls
{
    partial class SimetricnaUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEncyrpt = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxPlainText = new System.Windows.Forms.RichTextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGetHash = new System.Windows.Forms.Button();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(396, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simetrična kriptografija - AES";
            // 
            // buttonEncyrpt
            // 
            this.buttonEncyrpt.Location = new System.Drawing.Point(132, 108);
            this.buttonEncyrpt.Name = "buttonEncyrpt";
            this.buttonEncyrpt.Size = new System.Drawing.Size(108, 40);
            this.buttonEncyrpt.TabIndex = 1;
            this.buttonEncyrpt.Text = "Encrypt";
            this.buttonEncyrpt.UseVisualStyleBackColor = true;
            this.buttonEncyrpt.Click += new System.EventHandler(this.buttonEncyrpt_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxPlainText
            // 
            this.richTextBoxPlainText.Location = new System.Drawing.Point(18, 154);
            this.richTextBoxPlainText.Name = "richTextBoxPlainText";
            this.richTextBoxPlainText.Size = new System.Drawing.Size(904, 455);
            this.richTextBoxPlainText.TabIndex = 4;
            this.richTextBoxPlainText.Text = "Text to encrypt...";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(246, 108);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(108, 40);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.Location = new System.Drawing.Point(18, 108);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(108, 40);
            this.buttonGenerateKey.TabIndex = 6;
            this.buttonGenerateKey.Text = "Generate key";
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(814, 108);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(108, 40);
            this.buttonReadFromFile.TabIndex = 7;
            this.buttonReadFromFile.Text = "Read from file";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonGetHash
            // 
            this.buttonGetHash.Location = new System.Drawing.Point(18, 39);
            this.buttonGetHash.Name = "buttonGetHash";
            this.buttonGetHash.Size = new System.Drawing.Size(336, 40);
            this.buttonGetHash.TabIndex = 8;
            this.buttonGetHash.Text = "Get hash";
            this.buttonGetHash.UseVisualStyleBackColor = true;
            this.buttonGetHash.Click += new System.EventHandler(this.buttonGetHash_Click);
            // 
            // textBoxHash
            // 
            this.textBoxHash.Enabled = false;
            this.textBoxHash.Location = new System.Drawing.Point(534, 50);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(388, 20);
            this.textBoxHash.TabIndex = 9;
            // 
            // SimetricnaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.buttonGetHash);
            this.Controls.Add(this.buttonReadFromFile);
            this.Controls.Add(this.buttonGenerateKey);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.richTextBoxPlainText);
            this.Controls.Add(this.buttonEncyrpt);
            this.Controls.Add(this.label1);
            this.Name = "SimetricnaUC";
            this.Size = new System.Drawing.Size(1012, 648);
            this.Load += new System.EventHandler(this.SimetricnaUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEncyrpt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBoxPlainText;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonGetHash;
        private System.Windows.Forms.TextBox textBoxHash;
    }
}
