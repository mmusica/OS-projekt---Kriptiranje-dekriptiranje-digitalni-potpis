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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEncyrpt = new System.Windows.Forms.Button();
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
            this.buttonEncyrpt.Location = new System.Drawing.Point(538, 201);
            this.buttonEncyrpt.Name = "buttonEncyrpt";
            this.buttonEncyrpt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncyrpt.TabIndex = 1;
            this.buttonEncyrpt.Text = "Encrypt";
            this.buttonEncyrpt.UseVisualStyleBackColor = true;
            this.buttonEncyrpt.Click += new System.EventHandler(this.buttonEncyrpt_Click);
            // 
            // SimetricnaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEncyrpt);
            this.Controls.Add(this.label1);
            this.Name = "SimetricnaUC";
            this.Size = new System.Drawing.Size(1182, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEncyrpt;
    }
}
