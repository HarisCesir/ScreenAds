namespace ScreenAds
{
    partial class KlijentiForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxKontaktOsoba = new System.Windows.Forms.TextBox();
            this.maskedTextBoxKontaktTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNazivKlijenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewKlijenti = new System.Windows.Forms.DataGridView();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakttelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxKontaktOsoba);
            this.groupBox1.Controls.Add(this.maskedTextBoxKontaktTelefon);
            this.groupBox1.Controls.Add(this.textBoxNazivKlijenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj klijenta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxKontaktOsoba
            // 
            this.textBoxKontaktOsoba.Location = new System.Drawing.Point(54, 118);
            this.textBoxKontaktOsoba.Name = "textBoxKontaktOsoba";
            this.textBoxKontaktOsoba.Size = new System.Drawing.Size(185, 20);
            this.textBoxKontaktOsoba.TabIndex = 5;
            this.textBoxKontaktOsoba.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKontaktOsoba_Validating);
            // 
            // maskedTextBoxKontaktTelefon
            // 
            this.maskedTextBoxKontaktTelefon.Location = new System.Drawing.Point(54, 71);
            this.maskedTextBoxKontaktTelefon.Mask = "(999) 000-000";
            this.maskedTextBoxKontaktTelefon.Name = "maskedTextBoxKontaktTelefon";
            this.maskedTextBoxKontaktTelefon.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxKontaktTelefon.TabIndex = 4;
            // 
            // textBoxNazivKlijenta
            // 
            this.textBoxNazivKlijenta.Location = new System.Drawing.Point(54, 32);
            this.textBoxNazivKlijenta.Name = "textBoxNazivKlijenta";
            this.textBoxNazivKlijenta.Size = new System.Drawing.Size(212, 20);
            this.textBoxNazivKlijenta.TabIndex = 3;
            this.textBoxNazivKlijenta.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNazivKlijenta_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt osoba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kontakt telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // dataGridViewKlijenti
            // 
            this.dataGridViewKlijenti.AllowUserToAddRows = false;
            this.dataGridViewKlijenti.AllowUserToDeleteRows = false;
            this.dataGridViewKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentID,
            this.Naziv,
            this.KontaktOsoba,
            this.Kontakttelefon});
            this.dataGridViewKlijenti.Location = new System.Drawing.Point(304, 44);
            this.dataGridViewKlijenti.Name = "dataGridViewKlijenti";
            this.dataGridViewKlijenti.ReadOnly = true;
            this.dataGridViewKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKlijenti.Size = new System.Drawing.Size(344, 163);
            this.dataGridViewKlijenti.TabIndex = 1;
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "KlijentID";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.ReadOnly = true;
            this.KlijentID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt osoba";
            this.KontaktOsoba.Name = "KontaktOsoba";
            this.KontaktOsoba.ReadOnly = true;
            // 
            // Kontakttelefon
            // 
            this.Kontakttelefon.DataPropertyName = "KontaktTelefon";
            this.Kontakttelefon.HeaderText = "Kontakt telefon";
            this.Kontakttelefon.Name = "Kontakttelefon";
            this.Kontakttelefon.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Obriši klijenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Više informacija";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // KlijentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 210);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewKlijenti);
            this.Controls.Add(this.groupBox1);
            this.Name = "KlijentiForm";
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.KlijentiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxKontaktOsoba;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKontaktTelefon;
        private System.Windows.Forms.TextBox textBoxNazivKlijenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakttelefon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}