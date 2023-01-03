namespace Kriptografija.UserControls
{
    partial class AsimetricnaUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.buttonGetHash = new System.Windows.Forms.Button();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.buttonGenerateKeyPair = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.richTextBoxPlainText = new System.Windows.Forms.RichTextBox();
            this.buttonEncyrpt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(394, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asimetrična kriptografija - RSA";
            // 
            // textBoxHash
            // 
            this.textBoxHash.Enabled = false;
            this.textBoxHash.Location = new System.Drawing.Point(540, 79);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(388, 20);
            this.textBoxHash.TabIndex = 16;
            // 
            // buttonGetHash
            // 
            this.buttonGetHash.Location = new System.Drawing.Point(24, 68);
            this.buttonGetHash.Name = "buttonGetHash";
            this.buttonGetHash.Size = new System.Drawing.Size(336, 40);
            this.buttonGetHash.TabIndex = 15;
            this.buttonGetHash.Text = "Get hash";
            this.buttonGetHash.UseVisualStyleBackColor = true;
            this.buttonGetHash.Click += new System.EventHandler(this.buttonGetHash_Click);
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(820, 137);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(108, 40);
            this.buttonReadFromFile.TabIndex = 14;
            this.buttonReadFromFile.Text = "Read from file";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            // 
            // buttonGenerateKeyPair
            // 
            this.buttonGenerateKeyPair.Location = new System.Drawing.Point(24, 137);
            this.buttonGenerateKeyPair.Name = "buttonGenerateKeyPair";
            this.buttonGenerateKeyPair.Size = new System.Drawing.Size(108, 40);
            this.buttonGenerateKeyPair.TabIndex = 13;
            this.buttonGenerateKeyPair.Text = "Generate key pair";
            this.buttonGenerateKeyPair.UseVisualStyleBackColor = true;
            this.buttonGenerateKeyPair.Click += new System.EventHandler(this.buttonGenerateKeyPair_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(252, 137);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(108, 40);
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // richTextBoxPlainText
            // 
            this.richTextBoxPlainText.Location = new System.Drawing.Point(24, 183);
            this.richTextBoxPlainText.Name = "richTextBoxPlainText";
            this.richTextBoxPlainText.Size = new System.Drawing.Size(904, 455);
            this.richTextBoxPlainText.TabIndex = 11;
            this.richTextBoxPlainText.Text = "Text to encrypt...";
            this.richTextBoxPlainText.TextChanged += new System.EventHandler(this.richTextBoxPlainText_TextChanged);
            // 
            // buttonEncyrpt
            // 
            this.buttonEncyrpt.Location = new System.Drawing.Point(138, 137);
            this.buttonEncyrpt.Name = "buttonEncyrpt";
            this.buttonEncyrpt.Size = new System.Drawing.Size(108, 40);
            this.buttonEncyrpt.TabIndex = 10;
            this.buttonEncyrpt.Text = "Encrypt";
            this.buttonEncyrpt.UseVisualStyleBackColor = true;
            this.buttonEncyrpt.Click += new System.EventHandler(this.buttonEncyrpt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AsimetricnaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.buttonGetHash);
            this.Controls.Add(this.buttonReadFromFile);
            this.Controls.Add(this.buttonGenerateKeyPair);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.richTextBoxPlainText);
            this.Controls.Add(this.buttonEncyrpt);
            this.Controls.Add(this.label1);
            this.Name = "AsimetricnaUC";
            this.Size = new System.Drawing.Size(1069, 648);
            this.Load += new System.EventHandler(this.AsimetricnaUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Button buttonGetHash;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.Button buttonGenerateKeyPair;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.RichTextBox richTextBoxPlainText;
        private System.Windows.Forms.Button buttonEncyrpt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
