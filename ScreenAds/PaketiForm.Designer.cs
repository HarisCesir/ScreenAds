namespace ScreenAds
{
    partial class PaketiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivPaketa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTV = new System.Windows.Forms.ComboBox();
            this.comboBoxPaketiTv = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.maskedTextBoxTermin = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPaketiTermin = new System.Windows.Forms.ComboBox();
            this.dataGridViewTelevizije = new System.Windows.Forms.DataGridView();
            this.PaketiTelevizijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTelevizije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivGrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivObjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaObjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxpaketiGrid = new System.Windows.Forms.ComboBox();
            this.dataGridViewTermini = new System.Windows.Forms.DataGridView();
            this.Termin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxPaketiBrisanje = new System.Windows.Forms.ComboBox();
            this.buttonObrisiPake = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelevizije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv paketa:";
            // 
            // textBoxNazivPaketa
            // 
            this.textBoxNazivPaketa.Location = new System.Drawing.Point(9, 32);
            this.textBoxNazivPaketa.Name = "textBoxNazivPaketa";
            this.textBoxNazivPaketa.Size = new System.Drawing.Size(153, 20);
            this.textBoxNazivPaketa.TabIndex = 1;
            this.textBoxNazivPaketa.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNazivPaketa_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxNazivPaketa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj paket";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBoxTV);
            this.groupBox2.Controls.Add(this.comboBoxPaketiTv);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj televizije u paket";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxTV
            // 
            this.comboBoxTV.FormattingEnabled = true;
            this.comboBoxTV.Location = new System.Drawing.Point(17, 60);
            this.comboBoxTV.Name = "comboBoxTV";
            this.comboBoxTV.Size = new System.Drawing.Size(164, 21);
            this.comboBoxTV.TabIndex = 1;
            // 
            // comboBoxPaketiTv
            // 
            this.comboBoxPaketiTv.FormattingEnabled = true;
            this.comboBoxPaketiTv.Location = new System.Drawing.Point(17, 31);
            this.comboBoxPaketiTv.Name = "comboBoxPaketiTv";
            this.comboBoxPaketiTv.Size = new System.Drawing.Size(164, 21);
            this.comboBoxPaketiTv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.maskedTextBoxTermin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxPaketiTermin);
            this.groupBox3.Location = new System.Drawing.Point(562, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 134);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj termine u paket";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maskedTextBoxTermin
            // 
            this.maskedTextBoxTermin.Location = new System.Drawing.Point(23, 80);
            this.maskedTextBoxTermin.Mask = "90:00";
            this.maskedTextBoxTermin.Name = "maskedTextBoxTermin";
            this.maskedTextBoxTermin.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBoxTermin.TabIndex = 2;
            this.maskedTextBoxTermin.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termin";
            // 
            // comboBoxPaketiTermin
            // 
            this.comboBoxPaketiTermin.FormattingEnabled = true;
            this.comboBoxPaketiTermin.Location = new System.Drawing.Point(23, 31);
            this.comboBoxPaketiTermin.Name = "comboBoxPaketiTermin";
            this.comboBoxPaketiTermin.Size = new System.Drawing.Size(188, 21);
            this.comboBoxPaketiTermin.TabIndex = 0;
            // 
            // dataGridViewTelevizije
            // 
            this.dataGridViewTelevizije.AllowUserToAddRows = false;
            this.dataGridViewTelevizije.AllowUserToDeleteRows = false;
            this.dataGridViewTelevizije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelevizije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaketiTelevizijaID,
            this.NazivTelevizije,
            this.NazivGrada,
            this.NazivObjekta,
            this.AdresaObjekta});
            this.dataGridViewTelevizije.Location = new System.Drawing.Point(2, 233);
            this.dataGridViewTelevizije.Name = "dataGridViewTelevizije";
            this.dataGridViewTelevizije.ReadOnly = true;
            this.dataGridViewTelevizije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTelevizije.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewTelevizije.TabIndex = 6;
            // 
            // PaketiTelevizijaID
            // 
            this.PaketiTelevizijaID.DataPropertyName = "PaketiTelevizijeID";
            this.PaketiTelevizijaID.HeaderText = "PaketiTelevizijaID";
            this.PaketiTelevizijaID.Name = "PaketiTelevizijaID";
            this.PaketiTelevizijaID.ReadOnly = true;
            this.PaketiTelevizijaID.Visible = false;
            // 
            // NazivTelevizije
            // 
            this.NazivTelevizije.DataPropertyName = "NazivTelevizije";
            this.NazivTelevizije.HeaderText = "Broj Tv-a";
            this.NazivTelevizije.Name = "NazivTelevizije";
            this.NazivTelevizije.ReadOnly = true;
            // 
            // NazivGrada
            // 
            this.NazivGrada.DataPropertyName = "NazivGrada";
            this.NazivGrada.HeaderText = "Naziv grada";
            this.NazivGrada.Name = "NazivGrada";
            this.NazivGrada.ReadOnly = true;
            // 
            // NazivObjekta
            // 
            this.NazivObjekta.DataPropertyName = "NazivObjekta";
            this.NazivObjekta.HeaderText = "Naziv objekta";
            this.NazivObjekta.Name = "NazivObjekta";
            this.NazivObjekta.ReadOnly = true;
            // 
            // AdresaObjekta
            // 
            this.AdresaObjekta.DataPropertyName = "AdresaObjekta";
            this.AdresaObjekta.HeaderText = "¸Adresa objekta";
            this.AdresaObjekta.Name = "AdresaObjekta";
            this.AdresaObjekta.ReadOnly = true;
            // 
            // comboBoxpaketiGrid
            // 
            this.comboBoxpaketiGrid.FormattingEnabled = true;
            this.comboBoxpaketiGrid.Location = new System.Drawing.Point(2, 206);
            this.comboBoxpaketiGrid.Name = "comboBoxpaketiGrid";
            this.comboBoxpaketiGrid.Size = new System.Drawing.Size(121, 21);
            this.comboBoxpaketiGrid.TabIndex = 7;
            this.comboBoxpaketiGrid.SelectedIndexChanged += new System.EventHandler(this.comboBoxpaketiGrid_SelectedIndexChanged);
            // 
            // dataGridViewTermini
            // 
            this.dataGridViewTermini.AllowUserToAddRows = false;
            this.dataGridViewTermini.AllowUserToDeleteRows = false;
            this.dataGridViewTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Termin});
            this.dataGridViewTermini.Location = new System.Drawing.Point(501, 233);
            this.dataGridViewTermini.Name = "dataGridViewTermini";
            this.dataGridViewTermini.ReadOnly = true;
            this.dataGridViewTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTermini.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewTermini.TabIndex = 8;
            // 
            // Termin
            // 
            this.Termin.DataPropertyName = "Termin";
            this.Termin.HeaderText = "Termin";
            this.Termin.Name = "Termin";
            this.Termin.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Obriši termin";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(129, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Obriši tv";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBoxPaketiBrisanje
            // 
            this.comboBoxPaketiBrisanje.FormattingEnabled = true;
            this.comboBoxPaketiBrisanje.Location = new System.Drawing.Point(12, 140);
            this.comboBoxPaketiBrisanje.Name = "comboBoxPaketiBrisanje";
            this.comboBoxPaketiBrisanje.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPaketiBrisanje.TabIndex = 11;
            // 
            // buttonObrisiPake
            // 
            this.buttonObrisiPake.Location = new System.Drawing.Point(12, 167);
            this.buttonObrisiPake.Name = "buttonObrisiPake";
            this.buttonObrisiPake.Size = new System.Drawing.Size(200, 23);
            this.buttonObrisiPake.TabIndex = 12;
            this.buttonObrisiPake.Text = "Obriši paket";
            this.buttonObrisiPake.UseVisualStyleBackColor = true;
            this.buttonObrisiPake.Click += new System.EventHandler(this.buttonObrisiPake_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PaketiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 429);
            this.Controls.Add(this.buttonObrisiPake);
            this.Controls.Add(this.comboBoxPaketiBrisanje);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridViewTermini);
            this.Controls.Add(this.comboBoxpaketiGrid);
            this.Controls.Add(this.dataGridViewTelevizije);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaketiForm";
            this.Text = "Paketi";
            this.Load += new System.EventHandler(this.PaketiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelevizije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivPaketa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxTV;
        private System.Windows.Forms.ComboBox comboBoxPaketiTv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTermin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPaketiTermin;
        private System.Windows.Forms.DataGridView dataGridViewTelevizije;
        private System.Windows.Forms.ComboBox comboBoxpaketiGrid;
        private System.Windows.Forms.DataGridView dataGridViewTermini;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaketiTelevizijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTelevizije;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivGrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivObjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaObjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxPaketiBrisanje;
        private System.Windows.Forms.Button buttonObrisiPake;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}