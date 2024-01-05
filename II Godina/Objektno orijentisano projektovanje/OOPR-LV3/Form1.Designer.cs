using System.Windows.Forms;

namespace OOPR_LV3
{
    partial class OOProjektovanjeLV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OOProjektovanjeLV3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnZapamti = new System.Windows.Forms.Button();
            this.dtpOdabirDatuma = new System.Windows.Forms.DateTimePicker();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.btnObrisiJednuOsobu = new System.Windows.Forms.Button();
            this.btnObrisiListuOsoba = new System.Windows.Forms.Button();
            this.btnSortirajListu = new System.Windows.Forms.Button();
            this.cboNacinSortiranja = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAdresa);
            this.groupBox1.Controls.Add(this.btnPonisti);
            this.groupBox1.Controls.Add(this.btnZapamti);
            this.groupBox1.Controls.Add(this.dtpOdabirDatuma);
            this.groupBox1.Controls.Add(this.tbTelefon);
            this.groupBox1.Controls.Add(this.tbPrezime);
            this.groupBox1.Controls.Add(this.lblAdresa);
            this.groupBox1.Controls.Add(this.lblDatumRodjenja);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.tbIme);
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(503, 172);
=======
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 212);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o osobi";
            // 
            // tbAdresa
            // 
            this.tbAdresa.AcceptsTab = true;
<<<<<<< HEAD
            this.tbAdresa.Location = new System.Drawing.Point(256, 70);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdresa.Size = new System.Drawing.Size(195, 29);
=======
            this.tbAdresa.Location = new System.Drawing.Point(228, 86);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdresa.Size = new System.Drawing.Size(221, 34);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.tbAdresa.TabIndex = 11;
            this.tbAdresa.TextChanged += new System.EventHandler(this.tbAdresa_TextChanged);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Image = ((System.Drawing.Image)(resources.GetObject("btnPonisti.Image")));
            this.btnPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.btnPonisti.Location = new System.Drawing.Point(171, 110);
            this.btnPonisti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(90, 44);
=======
            this.btnPonisti.Location = new System.Drawing.Point(228, 135);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(120, 54);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.btnPonisti.TabIndex = 10;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPonisti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnZapamti
            // 
            this.btnZapamti.BackColor = System.Drawing.Color.Transparent;
            this.btnZapamti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZapamti.BackgroundImage")));
            this.btnZapamti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZapamti.ForeColor = System.Drawing.SystemColors.ControlText;
<<<<<<< HEAD
            this.btnZapamti.Location = new System.Drawing.Point(59, 110);
            this.btnZapamti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnZapamti.Size = new System.Drawing.Size(90, 44);
=======
            this.btnZapamti.Location = new System.Drawing.Point(79, 135);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnZapamti.Size = new System.Drawing.Size(120, 54);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.btnZapamti.TabIndex = 9;
            this.btnZapamti.Text = "Zapamti";
            this.btnZapamti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZapamti.UseVisualStyleBackColor = false;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // dtpOdabirDatuma
            // 
            this.dtpOdabirDatuma.CustomFormat = "dd.MM.yyyy.";
            this.dtpOdabirDatuma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
<<<<<<< HEAD
            this.dtpOdabirDatuma.Location = new System.Drawing.Point(362, 23);
            this.dtpOdabirDatuma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpOdabirDatuma.Name = "dtpOdabirDatuma";
            this.dtpOdabirDatuma.Size = new System.Drawing.Size(89, 20);
=======
            this.dtpOdabirDatuma.Location = new System.Drawing.Point(331, 29);
            this.dtpOdabirDatuma.Name = "dtpOdabirDatuma";
            this.dtpOdabirDatuma.Size = new System.Drawing.Size(118, 22);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.dtpOdabirDatuma.TabIndex = 8;
            this.dtpOdabirDatuma.ValueChanged += new System.EventHandler(this.dtpOdabirDatuma_ValueChanged);
            // 
            // tbTelefon
            // 
<<<<<<< HEAD
            this.tbTelefon.Location = new System.Drawing.Point(64, 79);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTelefon.MaxLength = 15;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(120, 20);
=======
            this.tbTelefon.Location = new System.Drawing.Point(85, 97);
            this.tbTelefon.MaxLength = 15;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(114, 22);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.tbTelefon.TabIndex = 7;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            // 
            // tbPrezime
            // 
<<<<<<< HEAD
            this.tbPrezime.Location = new System.Drawing.Point(64, 51);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(120, 20);
=======
            this.tbPrezime.Location = new System.Drawing.Point(85, 62);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(114, 22);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.tbPrezime.TabIndex = 6;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
<<<<<<< HEAD
            this.lblAdresa.Location = new System.Drawing.Point(253, 51);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(98, 13);
=======
            this.lblAdresa.Location = new System.Drawing.Point(224, 68);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(123, 16);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Adresa stanovanja:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
<<<<<<< HEAD
            this.lblDatumRodjenja.Location = new System.Drawing.Point(253, 26);
            this.lblDatumRodjenja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(81, 13);
=======
            this.lblDatumRodjenja.Location = new System.Drawing.Point(224, 35);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(101, 16);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lblDatumRodjenja.TabIndex = 4;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
<<<<<<< HEAD
            this.lblTelefon.Location = new System.Drawing.Point(9, 84);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
=======
            this.lblTelefon.Location = new System.Drawing.Point(12, 103);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
<<<<<<< HEAD
            this.lblPrezime.Location = new System.Drawing.Point(9, 55);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
=======
            this.lblPrezime.Location = new System.Drawing.Point(12, 68);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
<<<<<<< HEAD
            this.lblIme.Location = new System.Drawing.Point(9, 29);
            this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
=======
            this.lblIme.Location = new System.Drawing.Point(12, 35);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // tbIme
            // 
<<<<<<< HEAD
            this.tbIme.Location = new System.Drawing.Point(64, 23);
            this.tbIme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(120, 20);
=======
            this.tbIme.Location = new System.Drawing.Point(85, 29);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(114, 22);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.tbIme.TabIndex = 0;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.HorizontalScrollbar = true;
<<<<<<< HEAD
            this.lbLista.Location = new System.Drawing.Point(9, 227);
            this.lbLista.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbLista.Name = "lbLista";
            this.lbLista.ScrollAlwaysVisible = true;
            this.lbLista.Size = new System.Drawing.Size(503, 134);
=======
            this.lbLista.ItemHeight = 16;
            this.lbLista.Location = new System.Drawing.Point(12, 279);
            this.lbLista.Name = "lbLista";
            this.lbLista.ScrollAlwaysVisible = true;
            this.lbLista.Size = new System.Drawing.Size(503, 164);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lbLista.TabIndex = 1;
            this.lbLista.DoubleClick += new System.EventHandler(this.lbLista_DoubleClick);
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lbNaslov.Location = new System.Drawing.Point(140, 188);
            this.lbNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(136, 29);
=======
            this.lbNaslov.Location = new System.Drawing.Point(187, 232);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(168, 36);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.lbNaslov.TabIndex = 2;
            this.lbNaslov.Text = "Lista osoba";
            // 
            // btnObrisiJednuOsobu
            // 
            this.btnObrisiJednuOsobu.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiJednuOsobu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisiJednuOsobu.BackgroundImage")));
            this.btnObrisiJednuOsobu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnObrisiJednuOsobu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
<<<<<<< HEAD
            this.btnObrisiJednuOsobu.Location = new System.Drawing.Point(9, 377);
            this.btnObrisiJednuOsobu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnObrisiJednuOsobu.Name = "btnObrisiJednuOsobu";
            this.btnObrisiJednuOsobu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnObrisiJednuOsobu.Size = new System.Drawing.Size(112, 55);
=======
            this.btnObrisiJednuOsobu.Location = new System.Drawing.Point(12, 464);
            this.btnObrisiJednuOsobu.Name = "btnObrisiJednuOsobu";
            this.btnObrisiJednuOsobu.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnObrisiJednuOsobu.Size = new System.Drawing.Size(135, 47);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.btnObrisiJednuOsobu.TabIndex = 3;
            this.btnObrisiJednuOsobu.Text = "Obrisi izabranu \r\nosobu";
            this.btnObrisiJednuOsobu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiJednuOsobu.UseVisualStyleBackColor = false;
            this.btnObrisiJednuOsobu.Click += new System.EventHandler(this.btnObrisiJednuOsobu_Click);
            // 
            // btnObrisiListuOsoba
            // 
            this.btnObrisiListuOsoba.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObrisiListuOsoba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisiListuOsoba.BackgroundImage")));
            this.btnObrisiListuOsoba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
<<<<<<< HEAD
            this.btnObrisiListuOsoba.Location = new System.Drawing.Point(145, 377);
            this.btnObrisiListuOsoba.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnObrisiListuOsoba.Name = "btnObrisiListuOsoba";
            this.btnObrisiListuOsoba.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnObrisiListuOsoba.Size = new System.Drawing.Size(97, 55);
=======
            this.btnObrisiListuOsoba.Location = new System.Drawing.Point(153, 464);
            this.btnObrisiListuOsoba.Name = "btnObrisiListuOsoba";
            this.btnObrisiListuOsoba.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnObrisiListuOsoba.Size = new System.Drawing.Size(130, 47);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.btnObrisiListuOsoba.TabIndex = 4;
            this.btnObrisiListuOsoba.Text = "Obrisi listu osoba";
            this.btnObrisiListuOsoba.UseVisualStyleBackColor = true;
            this.btnObrisiListuOsoba.Click += new System.EventHandler(this.btnObrisiListuOsoba_Click);
            // 
            // btnSortirajListu
            // 
            this.btnSortirajListu.BackColor = System.Drawing.Color.Transparent;
            this.btnSortirajListu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSortirajListu.BackgroundImage")));
            this.btnSortirajListu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
<<<<<<< HEAD
            this.btnSortirajListu.Location = new System.Drawing.Point(265, 376);
            this.btnSortirajListu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSortirajListu.Name = "btnSortirajListu";
            this.btnSortirajListu.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnSortirajListu.Size = new System.Drawing.Size(80, 55);
=======
            this.btnSortirajListu.Location = new System.Drawing.Point(289, 464);
            this.btnSortirajListu.Name = "btnSortirajListu";
            this.btnSortirajListu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSortirajListu.Size = new System.Drawing.Size(95, 47);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.btnSortirajListu.TabIndex = 5;
            this.btnSortirajListu.Text = "Sortiraj listu";
            this.btnSortirajListu.UseVisualStyleBackColor = false;
            this.btnSortirajListu.Click += new System.EventHandler(this.btnSortirajListu_Click);
            // 
            // cboNacinSortiranja
            // 
            this.cboNacinSortiranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacinSortiranja.FormattingEnabled = true;
<<<<<<< HEAD
            this.cboNacinSortiranja.Location = new System.Drawing.Point(359, 392);
            this.cboNacinSortiranja.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboNacinSortiranja.Name = "cboNacinSortiranja";
            this.cboNacinSortiranja.Size = new System.Drawing.Size(153, 21);
=======
            this.cboNacinSortiranja.Location = new System.Drawing.Point(390, 476);
            this.cboNacinSortiranja.Name = "cboNacinSortiranja";
            this.cboNacinSortiranja.Size = new System.Drawing.Size(150, 24);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.cboNacinSortiranja.TabIndex = 6;
            this.cboNacinSortiranja.SelectedIndexChanged += new System.EventHandler(this.cboNacinSortiranja_SelectedIndexChanged);
            // 
            // OOProjektovanjeLV3
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 481);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 586);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.Controls.Add(this.cboNacinSortiranja);
            this.Controls.Add(this.btnSortirajListu);
            this.Controls.Add(this.btnObrisiListuOsoba);
            this.Controls.Add(this.btnObrisiJednuOsobu);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.groupBox1);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 534);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(451, 520);
=======
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(713, 649);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(597, 633);
>>>>>>> f1384bbd85cb1584decb6952e417487c476a32f7
            this.Name = "OOProjektovanjeLV3";
            this.ShowIcon = false;
            this.Text = "OOProjektovanje LV3";
            this.Load += new System.EventHandler(this.OOProjektovanjeLV3_Load);
            this.DoubleClick += new System.EventHandler(this.OOProjektovanjeLV3_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.DateTimePicker dtpOdabirDatuma;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Button btnObrisiJednuOsobu;
        private System.Windows.Forms.Button btnObrisiListuOsoba;
        private System.Windows.Forms.Button btnSortirajListu;
        private System.Windows.Forms.ComboBox cboNacinSortiranja;
        private TextBox tbAdresa;
        private ListBox lbLista;
    }
}

