namespace prjBrouwerij
{
    partial class frmBrouwerij
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
            this.lsbBrouwerijen = new System.Windows.Forms.ListBox();
            this.txtBrouwerij = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvBier = new System.Windows.Forms.ListView();
            this.Biernaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alcohol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kleur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsbBrouwerijen
            // 
            this.lsbBrouwerijen.FormattingEnabled = true;
            this.lsbBrouwerijen.Location = new System.Drawing.Point(313, 5);
            this.lsbBrouwerijen.Name = "lsbBrouwerijen";
            this.lsbBrouwerijen.Size = new System.Drawing.Size(142, 433);
            this.lsbBrouwerijen.TabIndex = 0;
            this.lsbBrouwerijen.SelectedIndexChanged += new System.EventHandler(this.lsbBrouwerijen_SelectedIndexChanged);
            // 
            // txtBrouwerij
            // 
            this.txtBrouwerij.Location = new System.Drawing.Point(69, 15);
            this.txtBrouwerij.Name = "txtBrouwerij";
            this.txtBrouwerij.Size = new System.Drawing.Size(238, 20);
            this.txtBrouwerij.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brouwerij:";
            // 
            // lsvBier
            // 
            this.lsvBier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Biernaam,
            this.Alcohol,
            this.Kleur});
            this.lsvBier.HideSelection = false;
            this.lsvBier.Location = new System.Drawing.Point(462, 5);
            this.lsvBier.Name = "lsvBier";
            this.lsvBier.Size = new System.Drawing.Size(447, 433);
            this.lsvBier.TabIndex = 3;
            this.lsvBier.UseCompatibleStateImageBehavior = false;
            this.lsvBier.View = System.Windows.Forms.View.Details;
            // 
            // Biernaam
            // 
            this.Biernaam.Text = "Biernaam";
            // 
            // Alcohol
            // 
            this.Alcohol.Text = "Alcohol";
            // 
            // Kleur
            // 
            this.Kleur.Text = "Kleur";
            // 
            // frmBrouwerij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 443);
            this.Controls.Add(this.lsvBier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrouwerij);
            this.Controls.Add(this.lsbBrouwerijen);
            this.Name = "frmBrouwerij";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbBrouwerijen;
        private System.Windows.Forms.TextBox txtBrouwerij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvBier;
        private System.Windows.Forms.ColumnHeader Biernaam;
        private System.Windows.Forms.ColumnHeader Alcohol;
        private System.Windows.Forms.ColumnHeader Kleur;
    }
}

