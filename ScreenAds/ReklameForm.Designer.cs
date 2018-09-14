namespace ScreenAds
{
    partial class ReklameForm
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
            this.textBoxNazivReklame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxKlijenti = new System.Windows.Forms.ComboBox();
            this.dataGridViewReklame = new System.Windows.Forms.DataGridView();
            this.ReklamaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuzinaReklame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontaktosoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxDuzina = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReklame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNazivReklame);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxVideo);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj reklamu";
            // 
            // textBoxNazivReklame
            // 
            this.textBoxNazivReklame.Location = new System.Drawing.Point(207, 19);
            this.textBoxNazivReklame.Name = "textBoxNazivReklame";
            this.textBoxNazivReklame.Size = new System.Drawing.Size(244, 20);
            this.textBoxNazivReklame.TabIndex = 4;
            this.textBoxNazivReklame.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNazivReklame_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj reklamu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Učitaj ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(6, 19);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.ReadOnly = true;
            this.textBoxVideo.Size = new System.Drawing.Size(195, 20);
            this.textBoxVideo.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // comboBoxKlijenti
            // 
            this.comboBoxKlijenti.FormattingEnabled = true;
            this.comboBoxKlijenti.Location = new System.Drawing.Point(12, 26);
            this.comboBoxKlijenti.Name = "comboBoxKlijenti";
            this.comboBoxKlijenti.Size = new System.Drawing.Size(298, 21);
            this.comboBoxKlijenti.TabIndex = 1;
            this.comboBoxKlijenti.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxKlijenti_Validating);
            // 
            // dataGridViewReklame
            // 
            this.dataGridViewReklame.AllowUserToAddRows = false;
            this.dataGridViewReklame.AllowUserToDeleteRows = false;
            this.dataGridViewReklame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReklame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReklamaID,
            this.Naziv,
            this.Video,
            this.DuzinaReklame,
            this.Klijent,
            this.Kontaktosoba,
            this.KontaktTelefon});
            this.dataGridViewReklame.Location = new System.Drawing.Point(-3, 217);
            this.dataGridViewReklame.Name = "dataGridViewReklame";
            this.dataGridViewReklame.ReadOnly = true;
            this.dataGridViewReklame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReklame.Size = new System.Drawing.Size(563, 136);
            this.dataGridViewReklame.TabIndex = 2;
            // 
            // ReklamaID
            // 
            this.ReklamaID.DataPropertyName = "ReklamaID";
            this.ReklamaID.HeaderText = "ReklamaID";
            this.ReklamaID.Name = "ReklamaID";
            this.ReklamaID.ReadOnly = true;
            this.ReklamaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Video
            // 
            this.Video.DataPropertyName = "Video";
            this.Video.HeaderText = "Video";
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            // 
            // DuzinaReklame
            // 
            this.DuzinaReklame.DataPropertyName = "DuzinaReklame";
            this.DuzinaReklame.HeaderText = "Dužina reklame";
            this.DuzinaReklame.Name = "DuzinaReklame";
            this.DuzinaReklame.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            // 
            // Kontaktosoba
            // 
            this.Kontaktosoba.DataPropertyName = "KontaktOsoba";
            this.Kontaktosoba.HeaderText = "Kontakt osoba";
            this.Kontaktosoba.Name = "Kontaktosoba";
            this.Kontaktosoba.ReadOnly = true;
            // 
            // KontaktTelefon
            // 
            this.KontaktTelefon.DataPropertyName = "KontaktTelefon";
            this.KontaktTelefon.HeaderText = "Kontakt telefon";
            this.KontaktTelefon.Name = "KontaktTelefon";
            this.KontaktTelefon.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Briši reklamu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Izmjeni reklamu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dužina reklame u sekundama";
            // 
            // maskedTextBoxDuzina
            // 
            this.maskedTextBoxDuzina.Location = new System.Drawing.Point(316, 27);
            this.maskedTextBoxDuzina.Mask = "00000";
            this.maskedTextBoxDuzina.Name = "maskedTextBoxDuzina";
            this.maskedTextBoxDuzina.Size = new System.Drawing.Size(161, 20);
            this.maskedTextBoxDuzina.TabIndex = 7;
            // 
            // ReklameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 380);
            this.Controls.Add(this.maskedTextBoxDuzina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridViewReklame);
            this.Controls.Add(this.comboBoxKlijenti);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReklameForm";
            this.Text = "ReklameForm";
            this.Load += new System.EventHandler(this.ReklameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReklame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxKlijenti;
        private System.Windows.Forms.DataGridView dataGridViewReklame;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxNazivReklame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDuzina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReklamaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuzinaReklame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontaktosoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktTelefon;
    }
}