namespace BTIpdks
{
    partial class PersonelGuncelle
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
            this.pcboxPersonelResim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgListe = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.dtIsGiris = new System.Windows.Forms.DateTimePicker();
            this.radioBtnPasif = new System.Windows.Forms.RadioButton();
            this.radioBtnAktif = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.maskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.txtPersonelKodu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtIscikis = new System.Windows.Forms.DateTimePicker();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPersonelResim)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxPersonelResim
            // 
            this.pcboxPersonelResim.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pcboxPersonelResim.Location = new System.Drawing.Point(121, 11);
            this.pcboxPersonelResim.Name = "pcboxPersonelResim";
            this.pcboxPersonelResim.Size = new System.Drawing.Size(124, 105);
            this.pcboxPersonelResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxPersonelResim.TabIndex = 26;
            this.pcboxPersonelResim.TabStop = false;
            this.pcboxPersonelResim.Click += new System.EventHandler(this.pcboxPersonelResim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Profil Resmi :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgListe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 309);
            this.panel1.TabIndex = 47;
            // 
            // dgListe
            // 
            this.dgListe.AllowUserToAddRows = false;
            this.dgListe.AllowUserToDeleteRows = false;
            this.dgListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListe.Location = new System.Drawing.Point(0, 0);
            this.dgListe.Name = "dgListe";
            this.dgListe.ReadOnly = true;
            this.dgListe.RowHeadersWidth = 51;
            this.dgListe.Size = new System.Drawing.Size(1264, 309);
            this.dgListe.TabIndex = 23;
            this.dgListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListe_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(751, 266);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(273, 63);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(855, 200);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(170, 21);
            this.cmbUnvan.TabIndex = 45;
            // 
            // dtIsGiris
            // 
            this.dtIsGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIsGiris.Location = new System.Drawing.Point(855, 110);
            this.dtIsGiris.MaxDate = new System.DateTime(2023, 4, 28, 0, 0, 0, 0);
            this.dtIsGiris.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtIsGiris.Name = "dtIsGiris";
            this.dtIsGiris.Size = new System.Drawing.Size(168, 20);
            this.dtIsGiris.TabIndex = 44;
            this.dtIsGiris.Value = new System.DateTime(2023, 4, 26, 0, 0, 0, 0);
            // 
            // radioBtnPasif
            // 
            this.radioBtnPasif.AutoSize = true;
            this.radioBtnPasif.Location = new System.Drawing.Point(908, 140);
            this.radioBtnPasif.Name = "radioBtnPasif";
            this.radioBtnPasif.Size = new System.Drawing.Size(48, 17);
            this.radioBtnPasif.TabIndex = 43;
            this.radioBtnPasif.Text = "Pasif";
            this.radioBtnPasif.UseVisualStyleBackColor = true;
            this.radioBtnPasif.CheckedChanged += new System.EventHandler(this.radioBtnPasif_CheckedChanged);
            // 
            // radioBtnAktif
            // 
            this.radioBtnAktif.AutoSize = true;
            this.radioBtnAktif.Location = new System.Drawing.Point(855, 140);
            this.radioBtnAktif.Name = "radioBtnAktif";
            this.radioBtnAktif.Size = new System.Drawing.Size(46, 17);
            this.radioBtnAktif.TabIndex = 42;
            this.radioBtnAktif.Text = "Aktif";
            this.radioBtnAktif.UseVisualStyleBackColor = true;
            this.radioBtnAktif.CheckedChanged += new System.EventHandler(this.radioBtnAktif_CheckedChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(855, 81);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(168, 20);
            this.txtMail.TabIndex = 41;
            // 
            // maskTxtTel
            // 
            this.maskTxtTel.Location = new System.Drawing.Point(400, 198);
            this.maskTxtTel.Mask = "(999) 000-0000";
            this.maskTxtTel.Name = "maskTxtTel";
            this.maskTxtTel.Size = new System.Drawing.Size(168, 20);
            this.maskTxtTel.TabIndex = 40;
            // 
            // maskTxtTc
            // 
            this.maskTxtTc.Location = new System.Drawing.Point(400, 167);
            this.maskTxtTc.Mask = "00000000000";
            this.maskTxtTc.Name = "maskTxtTc";
            this.maskTxtTc.Size = new System.Drawing.Size(168, 20);
            this.maskTxtTc.TabIndex = 39;
            this.maskTxtTc.ValidatingType = typeof(int);
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(400, 137);
            this.txtPersonelSoyadi.MaxLength = 30;
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(168, 20);
            this.txtPersonelSoyadi.TabIndex = 38;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(400, 108);
            this.txtPersonelAdi.MaxLength = 30;
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(168, 20);
            this.txtPersonelAdi.TabIndex = 37;
            // 
            // txtPersonelKodu
            // 
            this.txtPersonelKodu.Location = new System.Drawing.Point(400, 73);
            this.txtPersonelKodu.MaxLength = 7;
            this.txtPersonelKodu.Name = "txtPersonelKodu";
            this.txtPersonelKodu.Size = new System.Drawing.Size(168, 20);
            this.txtPersonelKodu.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(662, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Personel Meslek Unvanı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(682, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Personel Giriş Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(704, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Personel Durumu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(727, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Personel Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(288, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Personel Tel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(290, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Personel  TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(266, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Personel Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(287, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Personel Kodu :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(665, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Personel İş Çıkış Tarihi :";
            // 
            // dtIscikis
            // 
            this.dtIscikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIscikis.Location = new System.Drawing.Point(856, 165);
            this.dtIscikis.MaxDate = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.dtIscikis.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtIscikis.Name = "dtIscikis";
            this.dtIscikis.Size = new System.Drawing.Size(168, 20);
            this.dtIscikis.TabIndex = 49;
            this.dtIscikis.Value = new System.DateTime(2023, 4, 26, 0, 0, 0, 0);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(968, 141);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(25, 13);
            this.lblDurum.TabIndex = 50;
            this.lblDurum.Text = "------";
            this.lblDurum.Visible = false;
            this.lblDurum.TextChanged += new System.EventHandler(this.lblDurum_TextChanged);
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(230, 119);
            this.lblRef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(16, 13);
            this.lblRef.TabIndex = 51;
            this.lblRef.Text = "---";
            this.lblRef.Visible = false;
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 714);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dtIscikis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pcboxPersonelResim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.dtIsGiris);
            this.Controls.Add(this.radioBtnPasif);
            this.Controls.Add(this.radioBtnAktif);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.maskTxtTel);
            this.Controls.Add(this.maskTxtTc);
            this.Controls.Add(this.txtPersonelSoyadi);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.txtPersonelKodu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersonelGuncelle";
            this.Text = "Personel Güncele";
            this.Load += new System.EventHandler(this.PersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPersonelResim)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxPersonelResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgListe;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.DateTimePicker dtIsGiris;
        private System.Windows.Forms.RadioButton radioBtnPasif;
        private System.Windows.Forms.RadioButton radioBtnAktif;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox maskTxtTel;
        private System.Windows.Forms.MaskedTextBox maskTxtTc;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.TextBox txtPersonelKodu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtIscikis;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblRef;
    }
}