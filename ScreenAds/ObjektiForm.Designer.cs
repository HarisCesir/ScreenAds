namespace ScreenAds
{
    partial class ObjektiForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxKontaktTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKontaktOsoba = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxTipObjekta = new System.Windows.Forms.ComboBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ObjekatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLozinka);
            this.groupBox1.Controls.Add(this.textBoxKorisnickoIme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBoxKontaktTelefon);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxKontaktOsoba);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxTipObjekta);
            this.groupBox1.Controls.Add(this.textBoxAdresa);
            this.groupBox1.Controls.Add(this.textBoxNaziv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj objekat";
            // 
            // maskedTextBoxKontaktTelefon
            // 
            this.maskedTextBoxKontaktTelefon.Location = new System.Drawing.Point(25, 233);
            this.maskedTextBoxKontaktTelefon.Mask = "(999) 000-000";
            this.maskedTextBoxKontaktTelefon.Name = "maskedTextBoxKontaktTelefon";
            this.maskedTextBoxKontaktTelefon.Size = new System.Drawing.Size(142, 20);
            this.maskedTextBoxKontaktTelefon.TabIndex = 10;
            this.maskedTextBoxKontaktTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxKontaktTelefon_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kontakt telefon:";
            // 
            // textBoxKontaktOsoba
            // 
            this.textBoxKontaktOsoba.Location = new System.Drawing.Point(25, 176);
            this.textBoxKontaktOsoba.Name = "textBoxKontaktOsoba";
            this.textBoxKontaktOsoba.Size = new System.Drawing.Size(147, 20);
            this.textBoxKontaktOsoba.TabIndex = 8;
            this.textBoxKontaktOsoba.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kontakt osoba:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTipObjekta
            // 
            this.comboBoxTipObjekta.FormattingEnabled = true;
            this.comboBoxTipObjekta.Location = new System.Drawing.Point(25, 126);
            this.comboBoxTipObjekta.Name = "comboBoxTipObjekta";
            this.comboBoxTipObjekta.Size = new System.Drawing.Size(147, 21);
            this.comboBoxTipObjekta.TabIndex = 5;
            this.comboBoxTipObjekta.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxTipObjekta_Validating);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(25, 82);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(147, 20);
            this.textBoxAdresa.TabIndex = 4;
            this.textBoxAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresa_Validating);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(25, 33);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(147, 20);
            this.textBoxNaziv.TabIndex = 3;
            this.textBoxNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNaziv_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip objekta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjekatID,
            this.Naziv,
            this.NazivTip,
            this.Adresa,
            this.KontaktOsoba,
            this.KontaktTelefon});
            this.dataGridView1.Location = new System.Drawing.Point(336, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 284);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ObjekatID
            // 
            this.ObjekatID.DataPropertyName = "ObjekatID";
            this.ObjekatID.HeaderText = "ObjekatID";
            this.ObjekatID.Name = "ObjekatID";
            this.ObjekatID.ReadOnly = true;
            this.ObjekatID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "NazivObjekta";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // NazivTip
            // 
            this.NazivTip.DataPropertyName = "TipObjekta";
            this.NazivTip.HeaderText = "Tip objekta";
            this.NazivTip.Name = "NazivTip";
            this.NazivTip.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "AdresaObjekta";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(744, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Obriši objekat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(468, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Izmjeni objekat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Korisničko ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lozinka:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(27, 290);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(145, 20);
            this.textBoxKorisnickoIme.TabIndex = 13;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(27, 329);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(145, 20);
            this.textBoxLozinka.TabIndex = 14;
            // 
            // ObjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 416);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjektiForm";
            this.Text = "Objekti";
            this.Load += new System.EventHandler(this.ObjektiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxTipObjekta;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKontaktTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKontaktOsoba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjekatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktTelefon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}