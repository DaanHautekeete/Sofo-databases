namespace Voorbereiding_Apollo
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
            this.LVnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirmaNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gemeente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.txtGemeente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaamFirma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLevnr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLeveranciersNummer = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUitAssortiment = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBestelpunt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInBestelling = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGroepsnummer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNaamWijn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVerwijderWijn = new System.Windows.Forms.Button();
            this.btnWijnToevoegen = new System.Windows.Forms.Button();
            this.btnWijzigWijnen = new System.Windows.Forms.Button();
            this.txtVoorraad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoeveelheidPerVerpakking = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPPF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInhoud = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJaar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvWijnen = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Omschrijving = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Groepsnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inhoud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrijsPerFles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoeveelheidPerVerpakking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InBestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bestelpunt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UitAssortiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Leveranciersnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvLeveranciers
            // 
            this.lsvLeveranciers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVnr,
            this.FirmaNaam,
            this.Adres,
            this.Postnr,
            this.Gemeente});
            this.lsvLeveranciers.FullRowSelect = true;
            this.lsvLeveranciers.HideSelection = false;
            this.lsvLeveranciers.Location = new System.Drawing.Point(12, 12);
            this.lsvLeveranciers.Name = "lsvLeveranciers";
            this.lsvLeveranciers.Size = new System.Drawing.Size(381, 221);
            this.lsvLeveranciers.TabIndex = 0;
            this.lsvLeveranciers.UseCompatibleStateImageBehavior = false;
            this.lsvLeveranciers.View = System.Windows.Forms.View.Details;
            this.lsvLeveranciers.SelectedIndexChanged += new System.EventHandler(this.lsvLeveranciers_SelectedIndexChanged);
            // 
            // LVnr
            // 
            this.LVnr.Text = "LVnr";
            // 
            // FirmaNaam
            // 
            this.FirmaNaam.Text = "Firma naam";
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
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(247, 409);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 26;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(12, 409);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(75, 23);
            this.btnWijzig.TabIndex = 24;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // txtGemeente
            // 
            this.txtGemeente.Location = new System.Drawing.Point(136, 317);
            this.txtGemeente.Name = "txtGemeente";
            this.txtGemeente.Size = new System.Drawing.Size(100, 20);
            this.txtGemeente.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gemeente";
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(12, 317);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Postnr";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(247, 258);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adres";
            // 
            // txtNaamFirma
            // 
            this.txtNaamFirma.Location = new System.Drawing.Point(133, 258);
            this.txtNaamFirma.Name = "txtNaamFirma";
            this.txtNaamFirma.Size = new System.Drawing.Size(100, 20);
            this.txtNaamFirma.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Firma naam";
            // 
            // txtLevnr
            // 
            this.txtLevnr.Location = new System.Drawing.Point(12, 258);
            this.txtLevnr.Name = "txtLevnr";
            this.txtLevnr.Size = new System.Drawing.Size(100, 20);
            this.txtLevnr.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Levnr";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(773, 363);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(100, 20);
            this.txtFoto.TabIndex = 76;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(773, 346);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 75;
            this.label19.Text = "Foto";
            // 
            // txtLeveranciersNummer
            // 
            this.txtLeveranciersNummer.Enabled = false;
            this.txtLeveranciersNummer.Location = new System.Drawing.Point(650, 363);
            this.txtLeveranciersNummer.Name = "txtLeveranciersNummer";
            this.txtLeveranciersNummer.ReadOnly = true;
            this.txtLeveranciersNummer.Size = new System.Drawing.Size(100, 20);
            this.txtLeveranciersNummer.TabIndex = 74;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(650, 346);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Leveranciersnummer";
            // 
            // txtUitAssortiment
            // 
            this.txtUitAssortiment.Location = new System.Drawing.Point(522, 363);
            this.txtUitAssortiment.Name = "txtUitAssortiment";
            this.txtUitAssortiment.Size = new System.Drawing.Size(100, 20);
            this.txtUitAssortiment.TabIndex = 72;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(522, 346);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Uit assortiment";
            // 
            // txtBestelpunt
            // 
            this.txtBestelpunt.Location = new System.Drawing.Point(400, 363);
            this.txtBestelpunt.Name = "txtBestelpunt";
            this.txtBestelpunt.Size = new System.Drawing.Size(100, 20);
            this.txtBestelpunt.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(400, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Bestelpunt";
            // 
            // txtInBestelling
            // 
            this.txtInBestelling.Location = new System.Drawing.Point(890, 317);
            this.txtInBestelling.Name = "txtInBestelling";
            this.txtInBestelling.Size = new System.Drawing.Size(100, 20);
            this.txtInBestelling.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(890, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "In bestelling";
            // 
            // txtGroepsnummer
            // 
            this.txtGroepsnummer.Location = new System.Drawing.Point(889, 258);
            this.txtGroepsnummer.Name = "txtGroepsnummer";
            this.txtGroepsnummer.Size = new System.Drawing.Size(100, 20);
            this.txtGroepsnummer.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(889, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Groepsnummer";
            // 
            // txtNaamWijn
            // 
            this.txtNaamWijn.Location = new System.Drawing.Point(650, 258);
            this.txtNaamWijn.Name = "txtNaamWijn";
            this.txtNaamWijn.Size = new System.Drawing.Size(100, 20);
            this.txtNaamWijn.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(650, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Naam";
            // 
            // btnVerwijderWijn
            // 
            this.btnVerwijderWijn.Location = new System.Drawing.Point(650, 409);
            this.btnVerwijderWijn.Name = "btnVerwijderWijn";
            this.btnVerwijderWijn.Size = new System.Drawing.Size(100, 23);
            this.btnVerwijderWijn.TabIndex = 62;
            this.btnVerwijderWijn.Text = "Verwijder wijn";
            this.btnVerwijderWijn.UseVisualStyleBackColor = true;
            // 
            // btnWijnToevoegen
            // 
            this.btnWijnToevoegen.Location = new System.Drawing.Point(522, 409);
            this.btnWijnToevoegen.Name = "btnWijnToevoegen";
            this.btnWijnToevoegen.Size = new System.Drawing.Size(100, 23);
            this.btnWijnToevoegen.TabIndex = 61;
            this.btnWijnToevoegen.Text = "Wijn toevoegen";
            this.btnWijnToevoegen.UseVisualStyleBackColor = true;
            // 
            // btnWijzigWijnen
            // 
            this.btnWijzigWijnen.Location = new System.Drawing.Point(400, 409);
            this.btnWijzigWijnen.Name = "btnWijzigWijnen";
            this.btnWijzigWijnen.Size = new System.Drawing.Size(100, 23);
            this.btnWijzigWijnen.TabIndex = 60;
            this.btnWijzigWijnen.Text = "Wijzig wijnen";
            this.btnWijzigWijnen.UseVisualStyleBackColor = true;
            // 
            // txtVoorraad
            // 
            this.txtVoorraad.Location = new System.Drawing.Point(773, 317);
            this.txtVoorraad.Name = "txtVoorraad";
            this.txtVoorraad.Size = new System.Drawing.Size(100, 20);
            this.txtVoorraad.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(773, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Voorraad";
            // 
            // txtHoeveelheidPerVerpakking
            // 
            this.txtHoeveelheidPerVerpakking.Location = new System.Drawing.Point(650, 317);
            this.txtHoeveelheidPerVerpakking.Name = "txtHoeveelheidPerVerpakking";
            this.txtHoeveelheidPerVerpakking.Size = new System.Drawing.Size(100, 20);
            this.txtHoeveelheidPerVerpakking.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(650, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 37);
            this.label11.TabIndex = 56;
            this.label11.Text = "Hoeveelheid per verpakking";
            // 
            // txtPPF
            // 
            this.txtPPF.Location = new System.Drawing.Point(522, 317);
            this.txtPPF.Name = "txtPPF";
            this.txtPPF.Size = new System.Drawing.Size(100, 20);
            this.txtPPF.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "ppf";
            // 
            // txtInhoud
            // 
            this.txtInhoud.Location = new System.Drawing.Point(400, 317);
            this.txtInhoud.Name = "txtInhoud";
            this.txtInhoud.Size = new System.Drawing.Size(100, 20);
            this.txtInhoud.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Inhoud";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(773, 258);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(100, 20);
            this.txtOmschrijving.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(773, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Omschrijving";
            // 
            // txtJaar
            // 
            this.txtJaar.Location = new System.Drawing.Point(522, 258);
            this.txtJaar.Name = "txtJaar";
            this.txtJaar.Size = new System.Drawing.Size(100, 20);
            this.txtJaar.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Jaar";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(400, 258);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Code";
            // 
            // lsvWijnen
            // 
            this.lsvWijnen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Jaar,
            this.Naam,
            this.Omschrijving,
            this.Groepsnummer,
            this.Inhoud,
            this.PrijsPerFles,
            this.HoeveelheidPerVerpakking,
            this.Voorraad,
            this.InBestelling,
            this.Bestelpunt,
            this.UitAssortiment,
            this.Leveranciersnummer});
            this.lsvWijnen.FullRowSelect = true;
            this.lsvWijnen.HideSelection = false;
            this.lsvWijnen.Location = new System.Drawing.Point(403, 13);
            this.lsvWijnen.Name = "lsvWijnen";
            this.lsvWijnen.Size = new System.Drawing.Size(586, 220);
            this.lsvWijnen.TabIndex = 77;
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
            // Naam
            // 
            this.Naam.Text = "Naam";
            // 
            // Omschrijving
            // 
            this.Omschrijving.Text = "Omschrijving";
            // 
            // Groepsnummer
            // 
            this.Groepsnummer.Text = "Groepsnummer";
            // 
            // Inhoud
            // 
            this.Inhoud.Text = "Inhoud";
            // 
            // PrijsPerFles
            // 
            this.PrijsPerFles.Text = "PrijsPerFles";
            // 
            // HoeveelheidPerVerpakking
            // 
            this.HoeveelheidPerVerpakking.Text = "Hoeveelheid per verpakking";
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            // 
            // InBestelling
            // 
            this.InBestelling.Text = "In bestelling";
            // 
            // Bestelpunt
            // 
            this.Bestelpunt.Text = "Bestelpunt";
            // 
            // UitAssortiment
            // 
            this.UitAssortiment.Text = "Uit assortiment";
            // 
            // Leveranciersnummer
            // 
            this.Leveranciersnummer.Text = "Leveranciersnummer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 462);
            this.Controls.Add(this.lsvWijnen);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtLeveranciersNummer);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtUitAssortiment);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBestelpunt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtInBestelling);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtGroepsnummer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNaamWijn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnVerwijderWijn);
            this.Controls.Add(this.btnWijnToevoegen);
            this.Controls.Add(this.btnWijzigWijnen);
            this.Controls.Add(this.txtVoorraad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHoeveelheidPerVerpakking);
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
        private System.Windows.Forms.ColumnHeader LVnr;
        private System.Windows.Forms.ColumnHeader FirmaNaam;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Postnr;
        private System.Windows.Forms.ColumnHeader Gemeente;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.TextBox txtGemeente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaamFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLevnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLeveranciersNummer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUitAssortiment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBestelpunt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInBestelling;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGroepsnummer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNaamWijn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnVerwijderWijn;
        private System.Windows.Forms.Button btnWijnToevoegen;
        private System.Windows.Forms.Button btnWijzigWijnen;
        private System.Windows.Forms.TextBox txtVoorraad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHoeveelheidPerVerpakking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInhoud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJaar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lsvWijnen;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Jaar;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Omschrijving;
        private System.Windows.Forms.ColumnHeader Groepsnummer;
        private System.Windows.Forms.ColumnHeader Inhoud;
        private System.Windows.Forms.ColumnHeader PrijsPerFles;
        private System.Windows.Forms.ColumnHeader HoeveelheidPerVerpakking;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.ColumnHeader InBestelling;
        private System.Windows.Forms.ColumnHeader Bestelpunt;
        private System.Windows.Forms.ColumnHeader UitAssortiment;
        private System.Windows.Forms.ColumnHeader Leveranciersnummer;
    }
}

