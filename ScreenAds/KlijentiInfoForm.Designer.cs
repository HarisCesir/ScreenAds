namespace ScreenAds
{
    partial class KlijentiInfoForm
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
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKontaktTelefon = new System.Windows.Forms.TextBox();
            this.textBoxKontakOsoba = new System.Windows.Forms.TextBox();
            this.dataGridViewReklame = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ReklamaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewmarketing = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.MarketingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReklame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmarketing)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(12, 38);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.ReadOnly = true;
            this.textBoxNaziv.Size = new System.Drawing.Size(186, 20);
            this.textBoxNaziv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv klijenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kontak osoba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kontakt telefon";
            // 
            // textBoxKontaktTelefon
            // 
            this.textBoxKontaktTelefon.Location = new System.Drawing.Point(394, 38);
            this.textBoxKontaktTelefon.Name = "textBoxKontaktTelefon";
            this.textBoxKontaktTelefon.ReadOnly = true;
            this.textBoxKontaktTelefon.Size = new System.Drawing.Size(203, 20);
            this.textBoxKontaktTelefon.TabIndex = 4;
            // 
            // textBoxKontakOsoba
            // 
            this.textBoxKontakOsoba.Location = new System.Drawing.Point(204, 38);
            this.textBoxKontakOsoba.Name = "textBoxKontakOsoba";
            this.textBoxKontakOsoba.ReadOnly = true;
            this.textBoxKontakOsoba.Size = new System.Drawing.Size(184, 20);
            this.textBoxKontakOsoba.TabIndex = 5;
            // 
            // dataGridViewReklame
            // 
            this.dataGridViewReklame.AllowUserToAddRows = false;
            this.dataGridViewReklame.AllowUserToDeleteRows = false;
            this.dataGridViewReklame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReklame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReklamaID,
            this.Naziv,
            this.Video});
            this.dataGridViewReklame.Location = new System.Drawing.Point(1, 131);
            this.dataGridViewReklame.Name = "dataGridViewReklame";
            this.dataGridViewReklame.ReadOnly = true;
            this.dataGridViewReklame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReklame.Size = new System.Drawing.Size(387, 150);
            this.dataGridViewReklame.TabIndex = 6;
            this.dataGridViewReklame.SelectionChanged += new System.EventHandler(this.dataGridViewReklame_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "REKLAME";
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
            this.Video.HeaderText = "Link reklame";
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            // 
            // dataGridViewmarketing
            // 
            this.dataGridViewmarketing.AllowUserToAddRows = false;
            this.dataGridViewmarketing.AllowUserToDeleteRows = false;
            this.dataGridViewmarketing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmarketing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarketingID,
            this.Paket,
            this.DatumOD,
            this.DatumDO});
            this.dataGridViewmarketing.Location = new System.Drawing.Point(394, 131);
            this.dataGridViewmarketing.Name = "dataGridViewmarketing";
            this.dataGridViewmarketing.ReadOnly = true;
            this.dataGridViewmarketing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewmarketing.Size = new System.Drawing.Size(450, 150);
            this.dataGridViewmarketing.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MARKETING";
            // 
            // MarketingID
            // 
            this.MarketingID.DataPropertyName = "MarketingID";
            this.MarketingID.HeaderText = "MarketingID";
            this.MarketingID.Name = "MarketingID";
            this.MarketingID.ReadOnly = true;
            this.MarketingID.Visible = false;
            // 
            // Paket
            // 
            this.Paket.DataPropertyName = "Paket";
            this.Paket.HeaderText = "Paket";
            this.Paket.Name = "Paket";
            this.Paket.ReadOnly = true;
            // 
            // DatumOD
            // 
            this.DatumOD.DataPropertyName = "DatumOd";
            this.DatumOD.HeaderText = "Datum od";
            this.DatumOD.Name = "DatumOD";
            this.DatumOD.ReadOnly = true;
            // 
            // DatumDO
            // 
            this.DatumDO.DataPropertyName = "DatumDo";
            this.DatumDO.HeaderText = "Datum do";
            this.DatumDO.Name = "DatumDO";
            this.DatumDO.ReadOnly = true;
            // 
            // KlijentiInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 282);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewmarketing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewReklame);
            this.Controls.Add(this.textBoxKontakOsoba);
            this.Controls.Add(this.textBoxKontaktTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNaziv);
            this.Name = "KlijentiInfoForm";
            this.Text = "KlijentiInfoForm";
            this.Load += new System.EventHandler(this.KlijentiInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReklame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmarketing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKontaktTelefon;
        private System.Windows.Forms.TextBox textBoxKontakOsoba;
        private System.Windows.Forms.DataGridView dataGridViewReklame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReklamaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridView dataGridViewmarketing;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDO;
        private System.Windows.Forms.Label label5;
    }
}