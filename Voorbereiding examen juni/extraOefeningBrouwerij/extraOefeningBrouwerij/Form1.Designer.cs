namespace extraOefeningBrouwerij
{
    partial class Form1
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
            this.btnToonData = new System.Windows.Forms.Button();
            this.lsvBrouwerijen = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Webpagina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBeschrijvingNL = new System.Windows.Forms.RichTextBox();
            this.txtBeschrijvingEN = new System.Windows.Forms.RichTextBox();
            this.btnPasBeschrijvingAan = new System.Windows.Forms.Button();
            this.btnVerwijderBrouwerij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToonData
            // 
            this.btnToonData.Location = new System.Drawing.Point(2, 7);
            this.btnToonData.Name = "btnToonData";
            this.btnToonData.Size = new System.Drawing.Size(799, 55);
            this.btnToonData.TabIndex = 0;
            this.btnToonData.Text = "Toon data in Listview ";
            this.btnToonData.UseVisualStyleBackColor = true;
            this.btnToonData.Click += new System.EventHandler(this.btnToonData_Click);
            // 
            // lsvBrouwerijen
            // 
            this.lsvBrouwerijen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Naam,
            this.Email,
            this.Webpagina});
            this.lsvBrouwerijen.FullRowSelect = true;
            this.lsvBrouwerijen.HideSelection = false;
            this.lsvBrouwerijen.Location = new System.Drawing.Point(2, 82);
            this.lsvBrouwerijen.Name = "lsvBrouwerijen";
            this.lsvBrouwerijen.Size = new System.Drawing.Size(799, 228);
            this.lsvBrouwerijen.TabIndex = 1;
            this.lsvBrouwerijen.UseCompatibleStateImageBehavior = false;
            this.lsvBrouwerijen.View = System.Windows.Forms.View.Details;
            this.lsvBrouwerijen.SelectedIndexChanged += new System.EventHandler(this.lsvBrouwerijen_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Width = 0;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 146;
            // 
            // Email
            // 
            this.Email.Text = "Emailadres";
            this.Email.Width = 241;
            // 
            // Webpagina
            // 
            this.Webpagina.Text = "Webpagina";
            this.Webpagina.Width = 281;
            // 
            // txtBeschrijvingNL
            // 
            this.txtBeschrijvingNL.BackColor = System.Drawing.Color.LightGreen;
            this.txtBeschrijvingNL.Location = new System.Drawing.Point(13, 333);
            this.txtBeschrijvingNL.Name = "txtBeschrijvingNL";
            this.txtBeschrijvingNL.Size = new System.Drawing.Size(364, 288);
            this.txtBeschrijvingNL.TabIndex = 2;
            this.txtBeschrijvingNL.Text = "";
            // 
            // txtBeschrijvingEN
            // 
            this.txtBeschrijvingEN.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtBeschrijvingEN.Location = new System.Drawing.Point(407, 333);
            this.txtBeschrijvingEN.Name = "txtBeschrijvingEN";
            this.txtBeschrijvingEN.Size = new System.Drawing.Size(364, 288);
            this.txtBeschrijvingEN.TabIndex = 3;
            this.txtBeschrijvingEN.Text = "";
            // 
            // btnPasBeschrijvingAan
            // 
            this.btnPasBeschrijvingAan.Location = new System.Drawing.Point(12, 627);
            this.btnPasBeschrijvingAan.Name = "btnPasBeschrijvingAan";
            this.btnPasBeschrijvingAan.Size = new System.Drawing.Size(365, 55);
            this.btnPasBeschrijvingAan.TabIndex = 4;
            this.btnPasBeschrijvingAan.Text = "Pas beschrijving aan";
            this.btnPasBeschrijvingAan.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderBrouwerij
            // 
            this.btnVerwijderBrouwerij.Location = new System.Drawing.Point(407, 627);
            this.btnVerwijderBrouwerij.Name = "btnVerwijderBrouwerij";
            this.btnVerwijderBrouwerij.Size = new System.Drawing.Size(365, 55);
            this.btnVerwijderBrouwerij.TabIndex = 5;
            this.btnVerwijderBrouwerij.Text = "Verwijder geselecteerde brouwerij";
            this.btnVerwijderBrouwerij.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 708);
            this.Controls.Add(this.btnVerwijderBrouwerij);
            this.Controls.Add(this.btnPasBeschrijvingAan);
            this.Controls.Add(this.txtBeschrijvingEN);
            this.Controls.Add(this.txtBeschrijvingNL);
            this.Controls.Add(this.lsvBrouwerijen);
            this.Controls.Add(this.btnToonData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToonData;
        private System.Windows.Forms.ListView lsvBrouwerijen;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Webpagina;
        private System.Windows.Forms.RichTextBox txtBeschrijvingNL;
        private System.Windows.Forms.RichTextBox txtBeschrijvingEN;
        private System.Windows.Forms.Button btnPasBeschrijvingAan;
        private System.Windows.Forms.Button btnVerwijderBrouwerij;
    }
}

