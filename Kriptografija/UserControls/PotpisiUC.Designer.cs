namespace Kriptografija.UserControls
{
    partial class PotpisiUC
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSignedHash = new System.Windows.Forms.RichTextBox();
            this.buttonCheckSignature = new System.Windows.Forms.Button();
            this.buttonAddSignature = new System.Windows.Forms.Button();
            this.richTextBoxCheckSignature = new System.Windows.Forms.RichTextBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(420, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digitalni Potpis";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(52, 157);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(455, 376);
            this.richTextBoxInput.TabIndex = 1;
            this.richTextBoxInput.Text = "Text to add signature to";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // richTextBoxSignedHash
            // 
            this.richTextBoxSignedHash.Location = new System.Drawing.Point(528, 157);
            this.richTextBoxSignedHash.Name = "richTextBoxSignedHash";
            this.richTextBoxSignedHash.Size = new System.Drawing.Size(455, 376);
            this.richTextBoxSignedHash.TabIndex = 2;
            this.richTextBoxSignedHash.Text = "";
            this.richTextBoxSignedHash.TextChanged += new System.EventHandler(this.richTextBoxSignedHash_TextChanged);
            // 
            // buttonCheckSignature
            // 
            this.buttonCheckSignature.Location = new System.Drawing.Point(528, 126);
            this.buttonCheckSignature.Name = "buttonCheckSignature";
            this.buttonCheckSignature.Size = new System.Drawing.Size(133, 25);
            this.buttonCheckSignature.TabIndex = 3;
            this.buttonCheckSignature.Text = "Check Signature";
            this.buttonCheckSignature.UseVisualStyleBackColor = true;
            this.buttonCheckSignature.Click += new System.EventHandler(this.buttonCheckSignature_Click);
            // 
            // buttonAddSignature
            // 
            this.buttonAddSignature.Location = new System.Drawing.Point(52, 112);
            this.buttonAddSignature.Name = "buttonAddSignature";
            this.buttonAddSignature.Size = new System.Drawing.Size(86, 39);
            this.buttonAddSignature.TabIndex = 4;
            this.buttonAddSignature.Text = "Add Signature";
            this.buttonAddSignature.UseVisualStyleBackColor = true;
            this.buttonAddSignature.Click += new System.EventHandler(this.buttonAddSignature_Click);
            // 
            // richTextBoxCheckSignature
            // 
            this.richTextBoxCheckSignature.Enabled = false;
            this.richTextBoxCheckSignature.Location = new System.Drawing.Point(667, 126);
            this.richTextBoxCheckSignature.Name = "richTextBoxCheckSignature";
            this.richTextBoxCheckSignature.Size = new System.Drawing.Size(316, 25);
            this.richTextBoxCheckSignature.TabIndex = 5;
            this.richTextBoxCheckSignature.Text = "";
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(144, 112);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(86, 39);
            this.buttonLoadFromFile.TabIndex = 6;
            this.buttonLoadFromFile.Text = "Read from file";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PotpisiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.richTextBoxCheckSignature);
            this.Controls.Add(this.buttonAddSignature);
            this.Controls.Add(this.buttonCheckSignature);
            this.Controls.Add(this.richTextBoxSignedHash);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "PotpisiUC";
            this.Size = new System.Drawing.Size(1182, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxSignedHash;
        private System.Windows.Forms.Button buttonCheckSignature;
        private System.Windows.Forms.Button buttonAddSignature;
        private System.Windows.Forms.RichTextBox richTextBoxCheckSignature;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
