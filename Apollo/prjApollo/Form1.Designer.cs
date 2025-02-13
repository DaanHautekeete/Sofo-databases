namespace prjApollo
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
            this.lsvLeveranciers = new System.Windows.Forms.ListView();
            this.Lvnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NaamFirma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gemeente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLevnr = new System.Windows.Forms.TextBox();
            this.txtNaamFirma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lsvWijnen = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Omschrijving = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inhoud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoeveelheidPerVerpakking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJaar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInhoud = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPPF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrijsPerPak = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVoorraad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnWijzigWijnen = new System.Windows.Forms.Button();
            this.btnWijnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijderWijn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvLeveranciers
            // 
            this.lsvLeveranciers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lvnr,
            this.NaamFirma,
            this.Adres,
            this.Postnr,
            this.Gemeente});
            this.lsvLeveranciers.FullRowSelect = true;
            this.lsvLeveranciers.HideSelection = false;
            this.lsvLeveranciers.Location = new System.Drawing.Point(13, 13);
            this.lsvLeveranciers.Name = "lsvLeveranciers";
            this.lsvLeveranciers.Size = new System.Drawing.Size(335, 276);
            this.lsvLeveranciers.TabIndex = 0;
            this.lsvLeveranciers.UseCompatibleStateImageBehavior = false;
            this.lsvLeveranciers.View = System.Windows.Forms.View.Details;
            this.lsvLeveranciers.SelectedIndexChanged += new System.EventHandler(this.lsvLeveranciers_SelectedIndexChanged);
            // 
            // Lvnr
            // 
            this.Lvnr.Text = "Lvnr";
            // 
            // NaamFirma
            // 
            this.NaamFirma.Text = "Firma naam";
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            // 
            // Postnr
            // 
            this.Postnr.Text = "Postnr";
            // 
            // Gemeente
            // 
            this.Gemeente.Text = "Gemeente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Levnr";
            // 
            // txtLevnr
            // 
            this.txtLevnr.Location = new System.Drawing.Point(13, 325);
            this.txtLevnr.Name = "txtLevnr";
            this.txtLevnr.Size = new System.Drawing.Size(100, 20);
            this.txtLevnr.TabIndex = 2;
            // 
            // txtNaamFirma
            // 
            this.txtNaamFirma.Location = new System.Drawing.Point(134, 325);
            this.txtNaamFirma.Name = "txtNaamFirma";
            this.txtNaamFirma.Size = new System.Drawing.Size(100, 20);
            this.txtNaamFirma.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma naam";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(248, 325);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(13, 384);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postnr";
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(137, 384);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(100, 20);
            this.txtGemeente.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gemeente";
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(13, 456);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 11;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(248, 456);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 13;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // lsvWijnen
            // 
            this.lsvWijnen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Jaar,
            this.Omschrijving,
            this.Inhoud,
            this.ppf,
            this.HoeveelheidPerVerpakking,
            this.Voorraad});
            this.lsvWijnen.FullRowSelect = true;
            this.lsvWijnen.HideSelection = false;
            this.lsvWijnen.Location = new System.Drawing.Point(484, 46);
            this.lsvWijnen.Name = "lsvWijnen";
            this.lsvWijnen.Size = new System.Drawing.Size(552, 243);
            this.lsvWijnen.TabIndex = 14;
            this.lsvWijnen.UseCompatibleStateImageBehavior = false;
            this.lsvWijnen.View = System.Windows.Forms.View.Details;
            this.lsvWijnen.SelectedIndexChanged += new System.EventHandler(this.lsvWijnen_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            // 
            // Jaar
            // 
            this.Jaar.Text = "Jaar";
            // 
            // Omschrijving
            // 
            this.Omschrijving.Text = "Omschrijving";
            // 
            // Inhoud
            // 
            this.Inhoud.Text = "Inhoud";
            // 
            // ppf
            // 
            this.ppf.Text = "ppf";
            // 
            // HoeveelheidPerVerpakking
            // 
            this.HoeveelheidPerVerpakking.Text = "Hoeveelheid per verpakking";
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            // 
            // cmbCode
            // 
            this.cmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Items.AddRange(new object[] {
            "Code"});
            this.cmbCode.Location = new System.Drawing.Point(692, 13);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(121, 21);
            this.cmbCode.TabIndex = 15;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(484, 325);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Code";
            // 
            // txtJaar
            // 
            this.txtJaar.Location = new System.Drawing.Point(606, 325);
            this.txtJaar.Name = "txtJaar";
            this.txtJaar.Size = new System.Drawing.Size(100, 20);
            this.txtJaar.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Jaar";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(734, 325);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(100, 20);
            this.txtOmschrijving.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(734, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Omschrijving";
            // 
            // txtInhoud
            // 
            this.txtInhoud.Location = new System.Drawing.Point(859, 325);
            this.txtInhoud.Name = "txtInhoud";
            this.txtInhoud.Size = new System.Drawing.Size(100, 20);
            this.txtInhoud.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(859, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Inhoud";
            // 
            // txtPPF
            // 
            this.txtPPF.Location = new System.Drawing.Point(484, 384);
            this.txtPPF.Name = "txtPPF";
            this.txtPPF.Size = new System.Drawing.Size(100, 20);
            this.txtPPF.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "ppf";
            // 
            // txtPrijsPerPak
            // 
            this.txtPrijsPerPak.Location = new System.Drawing.Point(606, 384);
            this.txtPrijsPerPak.Name = "txtPrijsPerPak";
            this.txtPrijsPerPak.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsPerPak.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Prijs per pak";
            // 
            // txtVoorraad
            // 
            this.txtVoorraad.Location = new System.Drawing.Point(734, 384);
            this.txtVoorraad.Name = "txtVoorraad";
            this.txtVoorraad.Size = new System.Drawing.Size(100, 20);
            this.txtVoorraad.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(734, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Voorraad";
            // 
            // btnWijzigWijnen
            // 
            this.btnWijzigWijnen.Location = new System.Drawing.Point(484, 456);
            this.btnWijzigWijnen.Name = "btnWijzigWijnen";
            this.btnWijzigWijnen.Size = new System.Drawing.Size(100, 23);
            this.btnWijzigWijnen.TabIndex = 30;
            this.btnWijzigWijnen.Text = "Wijzig wijnen";
            this.btnWijzigWijnen.UseVisualStyleBackColor = true;
            // 
            // btnWijnToevoegen
            // 
            this.btnWijnToevoegen.Location = new System.Drawing.Point(606, 456);
            this.btnWijnToevoegen.Name = "btnWijnToevoegen";
            this.btnWijnToevoegen.Size = new System.Drawing.Size(100, 23);
            this.btnWijnToevoegen.TabIndex = 31;
            this.btnWijnToevoegen.Text = "Wijn toevoegen";
            this.btnWijnToevoegen.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderWijn
            // 
            this.btnVerwijderWijn.Location = new System.Drawing.Point(734, 456);
            this.btnVerwijderWijn.Name = "btnVerwijderWijn";
            this.btnVerwijderWijn.Size = new System.Drawing.Size(100, 23);
            this.btnVerwijderWijn.TabIndex = 31;
            this.btnVerwijderWijn.Text = "Verwijder wijn";
            this.btnVerwijderWijn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 491);
            this.Controls.Add(this.btnVerwijderWijn);
            this.Controls.Add(this.btnWijnToevoegen);
            this.Controls.Add(this.btnWijzigWijnen);
            this.Controls.Add(this.txtVoorraad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrijsPerPak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPPF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInhoud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtJaar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.lsvWijnen);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.txtGemeente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPostnr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaamFirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLevnr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvLeveranciers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLeveranciers;
        private System.Windows.Forms.ColumnHeader Lvnr;
        private System.Windows.Forms.ColumnHeader NaamFirma;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Postnr;
        private System.Windows.Forms.ColumnHeader Gemeente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLevnr;
        private System.Windows.Forms.TextBox txtNaamFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListView lsvWijnen;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Jaar;
        private System.Windows.Forms.ColumnHeader Omschrijving;
        private System.Windows.Forms.ColumnHeader Inhoud;
        private System.Windows.Forms.ColumnHeader ppf;
        private System.Windows.Forms.ColumnHeader HoeveelheidPerVerpakking;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJaar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInhoud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrijsPerPak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVoorraad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnWijzigWijnen;
        private System.Windows.Forms.Button btnWijnToevoegen;
        private System.Windows.Forms.Button btnVerwijderWijn;
    }
}

