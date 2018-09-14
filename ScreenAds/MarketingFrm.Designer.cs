namespace ScreenAds
{
    partial class MarketingFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketingFrm));
            this.comboBoxPaketi = new System.Windows.Forms.ComboBox();
            this.comboBoxReklama = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPaketi = new System.Windows.Forms.DataGridView();
            this.PaketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTermini = new System.Windows.Forms.DataGridView();
            this.Termin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewReklame = new System.Windows.Forms.DataGridView();
            this.dataGridViewTelevizije = new System.Windows.Forms.DataGridView();
            this.NazivTelevizije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objekat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaObjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivReklame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuzinaReklame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaketi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReklame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelevizije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPaketi
            // 
            this.comboBoxPaketi.FormattingEnabled = true;
            this.comboBoxPaketi.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPaketi.Name = "comboBoxPaketi";
            this.comboBoxPaketi.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPaketi.TabIndex = 0;
            this.comboBoxPaketi.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPaketi_Validating);
            // 
            // comboBoxReklama
            // 
            this.comboBoxReklama.FormattingEnabled = true;
            this.comboBoxReklama.Location = new System.Drawing.Point(12, 54);
            this.comboBoxReklama.Name = "comboBoxReklama";
            this.comboBoxReklama.Size = new System.Drawing.Size(200, 21);
            this.comboBoxReklama.TabIndex = 1;
            this.comboBoxReklama.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxReklama_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 104);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 4, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 147);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum do:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(310, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Provjera slobodnih dana";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(275, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "BOLDIRANI DATUMI SU ZAUZETI ZA ODABRANI PAKET";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(12, 273);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker3.TabIndex = 10;
            this.dateTimePicker3.Value = new System.DateTime(2017, 5, 20, 0, 0, 0, 0);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datum:";
            // 
            // dataGridViewPaketi
            // 
            this.dataGridViewPaketi.AllowUserToAddRows = false;
            this.dataGridViewPaketi.AllowUserToDeleteRows = false;
            this.dataGridViewPaketi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaketi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaketID,
            this.Naziv});
            this.dataGridViewPaketi.Location = new System.Drawing.Point(12, 322);
            this.dataGridViewPaketi.Name = "dataGridViewPaketi";
            this.dataGridViewPaketi.ReadOnly = true;
            this.dataGridViewPaketi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaketi.Size = new System.Drawing.Size(147, 312);
            this.dataGridViewPaketi.TabIndex = 12;
            this.dataGridViewPaketi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaketi_CellClick);
            this.dataGridViewPaketi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaketi_CellContentClick);
            // 
            // PaketID
            // 
            this.PaketID.DataPropertyName = "PaketID";
            this.PaketID.HeaderText = "PaketID";
            this.PaketID.Name = "PaketID";
            this.PaketID.ReadOnly = true;
            this.PaketID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Paketi:";
            // 
            // dataGridViewTermini
            // 
            this.dataGridViewTermini.AllowUserToAddRows = false;
            this.dataGridViewTermini.AllowUserToDeleteRows = false;
            this.dataGridViewTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Termin});
            this.dataGridViewTermini.Location = new System.Drawing.Point(165, 322);
            this.dataGridViewTermini.Name = "dataGridViewTermini";
            this.dataGridViewTermini.ReadOnly = true;
            this.dataGridViewTermini.Size = new System.Drawing.Size(148, 312);
            this.dataGridViewTermini.TabIndex = 14;
            this.dataGridViewTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Termin
            // 
            this.Termin.DataPropertyName = "Termin";
            this.Termin.HeaderText = "Termin";
            this.Termin.Name = "Termin";
            this.Termin.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Termini:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Reklame:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Televizije:";
            // 
            // dataGridViewReklame
            // 
            this.dataGridViewReklame.AllowUserToAddRows = false;
            this.dataGridViewReklame.AllowUserToDeleteRows = false;
            this.dataGridViewReklame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReklame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivReklame,
            this.Video,
            this.DuzinaReklame,
            this.Klijent,
            this.KontaktOsoba,
            this.KontaktTelefon});
            this.dataGridViewReklame.Location = new System.Drawing.Point(319, 322);
            this.dataGridViewReklame.Name = "dataGridViewReklame";
            this.dataGridViewReklame.ReadOnly = true;
            this.dataGridViewReklame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReklame.Size = new System.Drawing.Size(646, 312);
            this.dataGridViewReklame.TabIndex = 18;
            // 
            // dataGridViewTelevizije
            // 
            this.dataGridViewTelevizije.AllowUserToAddRows = false;
            this.dataGridViewTelevizije.AllowUserToDeleteRows = false;
            this.dataGridViewTelevizije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelevizije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivTelevizije,
            this.Objekat,
            this.AdresaObjekta,
            this.Grad});
            this.dataGridViewTelevizije.Location = new System.Drawing.Point(971, 322);
            this.dataGridViewTelevizije.Name = "dataGridViewTelevizije";
            this.dataGridViewTelevizije.ReadOnly = true;
            this.dataGridViewTelevizije.Size = new System.Drawing.Size(447, 312);
            this.dataGridViewTelevizije.TabIndex = 19;
            // 
            // NazivTelevizije
            // 
            this.NazivTelevizije.DataPropertyName = "NazivTelevizije";
            this.NazivTelevizije.HeaderText = "Televizija";
            this.NazivTelevizije.Name = "NazivTelevizije";
            this.NazivTelevizije.ReadOnly = true;
            // 
            // Objekat
            // 
            this.Objekat.DataPropertyName = "NazivObjekta";
            this.Objekat.HeaderText = "Objekat";
            this.Objekat.Name = "Objekat";
            this.Objekat.ReadOnly = true;
            // 
            // AdresaObjekta
            // 
            this.AdresaObjekta.DataPropertyName = "AdresaObjekta";
            this.AdresaObjekta.HeaderText = "AdresaObjekta";
            this.AdresaObjekta.Name = "AdresaObjekta";
            this.AdresaObjekta.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "NazivGrada";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // NazivReklame
            // 
            this.NazivReklame.DataPropertyName = "Naziv";
            this.NazivReklame.HeaderText = "Naziv reklame";
            this.NazivReklame.Name = "NazivReklame";
            this.NazivReklame.ReadOnly = true;
            // 
            // Video
            // 
            this.Video.DataPropertyName = "Video";
            this.Video.HeaderText = "Link reklame";
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            // 
            // DuzinaReklame
            // 
            this.DuzinaReklame.DataPropertyName = "DuzinaReklame";
            this.DuzinaReklame.HeaderText = "Duzina reklame";
            this.DuzinaReklame.Name = "DuzinaReklame";
            this.DuzinaReklame.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "NazivKlijenta";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt osoba";
            this.KontaktOsoba.Name = "KontaktOsoba";
            this.KontaktOsoba.ReadOnly = true;
            // 
            // KontaktTelefon
            // 
            this.KontaktTelefon.DataPropertyName = "KontaktTelefon";
            this.KontaktTelefon.HeaderText = "Kontakt telefon";
            this.KontaktTelefon.Name = "KontaktTelefon";
            this.KontaktTelefon.ReadOnly = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(824, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(522, 301);
            this.axWindowsMediaPlayer1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Prikaži reklamu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MarketingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 632);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.dataGridViewTelevizije);
            this.Controls.Add(this.dataGridViewReklame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewTermini);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewPaketi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxReklama);
            this.Controls.Add(this.comboBoxPaketi);
            this.Name = "MarketingFrm";
            this.Text = "MarketingFrm";
            this.Load += new System.EventHandler(this.MarketingFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaketi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReklame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelevizije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPaketi;
        private System.Windows.Forms.ComboBox comboBoxReklama;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTermini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewPaketi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewTelevizije;
        private System.Windows.Forms.DataGridView dataGridViewReklame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTelevizije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objekat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaObjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivReklame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuzinaReklame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktTelefon;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button3;
    }
}