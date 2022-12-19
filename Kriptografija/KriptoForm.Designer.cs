namespace Kriptografija
{
    partial class KriptoForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonPotpis = new System.Windows.Forms.Button();
            this.buttonAsimetricna = new System.Windows.Forms.Button();
            this.buttonSimetricna = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer1.Panel1.Controls.Add(this.buttonPotpis);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAsimetricna);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSimetricna);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 657);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonPotpis
            // 
            this.buttonPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPotpis.Location = new System.Drawing.Point(3, 319);
            this.buttonPotpis.Name = "buttonPotpis";
            this.buttonPotpis.Size = new System.Drawing.Size(179, 89);
            this.buttonPotpis.TabIndex = 2;
            this.buttonPotpis.Text = "Digitalni potpis";
            this.buttonPotpis.UseVisualStyleBackColor = true;
            this.buttonPotpis.Click += new System.EventHandler(this.buttonPotpis_Click);
            // 
            // buttonAsimetricna
            // 
            this.buttonAsimetricna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAsimetricna.Location = new System.Drawing.Point(3, 204);
            this.buttonAsimetricna.Name = "buttonAsimetricna";
            this.buttonAsimetricna.Size = new System.Drawing.Size(179, 89);
            this.buttonAsimetricna.TabIndex = 1;
            this.buttonAsimetricna.Text = "Asimetrična kriptografija";
            this.buttonAsimetricna.UseVisualStyleBackColor = true;
            this.buttonAsimetricna.Click += new System.EventHandler(this.buttonAsimetricna_Click);
            // 
            // buttonSimetricna
            // 
            this.buttonSimetricna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSimetricna.Location = new System.Drawing.Point(3, 89);
            this.buttonSimetricna.Name = "buttonSimetricna";
            this.buttonSimetricna.Size = new System.Drawing.Size(179, 89);
            this.buttonSimetricna.TabIndex = 0;
            this.buttonSimetricna.Text = "Simetrična kriptografija";
            this.buttonSimetricna.UseVisualStyleBackColor = true;
            this.buttonSimetricna.Click += new System.EventHandler(this.buttonSimetricna_Click);
            // 
            // KriptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 657);
            this.Controls.Add(this.splitContainer1);
            this.Name = "KriptoForm";
            this.Text = "Kriptografija";
            this.Load += new System.EventHandler(this.kriptoForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonPotpis;
        private System.Windows.Forms.Button buttonAsimetricna;
        private System.Windows.Forms.Button buttonSimetricna;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

