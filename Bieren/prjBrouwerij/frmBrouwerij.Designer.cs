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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBiernaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlcohol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKleur = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
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
            this.lsvBier.FullRowSelect = true;
            this.lsvBier.HideSelection = false;
            this.lsvBier.Location = new System.Drawing.Point(462, 5);
            this.lsvBier.Name = "lsvBier";
            this.lsvBier.Size = new System.Drawing.Size(447, 433);
            this.lsvBier.TabIndex = 3;
            this.lsvBier.UseCompatibleStateImageBehavior = false;
            this.lsvBier.View = System.Windows.Forms.View.Details;
            this.lsvBier.SelectedIndexChanged += new System.EventHandler(this.lsvBier_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Biernaam:";
            // 
            // txtBiernaam
            // 
            this.txtBiernaam.Location = new System.Drawing.Point(69, 102);
            this.txtBiernaam.Name = "txtBiernaam";
            this.txtBiernaam.Size = new System.Drawing.Size(238, 20);
            this.txtBiernaam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alcohol:";
            // 
            // txtAlcohol
            // 
            this.txtAlcohol.Location = new System.Drawing.Point(69, 144);
            this.txtAlcohol.Name = "txtAlcohol";
            this.txtAlcohol.Size = new System.Drawing.Size(238, 20);
            this.txtAlcohol.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kleur:";
            // 
            // txtKleur
            // 
            this.txtKleur.Location = new System.Drawing.Point(69, 181);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(238, 20);
            this.txtKleur.TabIndex = 8;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(16, 244);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(111, 35);
            this.btnToevoegen.TabIndex = 10;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(162, 244);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(111, 35);
            this.btnVerwijder.TabIndex = 11;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(92, 295);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(111, 35);
            this.btnAanpassen.TabIndex = 12;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // frmBrouwerij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 443);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlcohol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBiernaam);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBiernaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlcohol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKleur;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnAanpassen;
    }
}

