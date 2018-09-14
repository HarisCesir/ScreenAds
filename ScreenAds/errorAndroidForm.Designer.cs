namespace ScreenAds
{
    partial class errorAndroidForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewProvjera = new System.Windows.Forms.DataGridView();
            this.dataGridViewError = new System.Windows.Forms.DataGridView();
            this.ErrorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewProvjeraKasni = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvjera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvjeraKasni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provjera API sa Androida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Error Android";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProvjera
            // 
            this.dataGridViewProvjera.AllowUserToAddRows = false;
            this.dataGridViewProvjera.AllowUserToDeleteRows = false;
            this.dataGridViewProvjera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvjera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorID,
            this.NazivTV,
            this.Vrijeme});
            this.dataGridViewProvjera.Location = new System.Drawing.Point(2, 72);
            this.dataGridViewProvjera.Name = "dataGridViewProvjera";
            this.dataGridViewProvjera.ReadOnly = true;
            this.dataGridViewProvjera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProvjera.Size = new System.Drawing.Size(252, 361);
            this.dataGridViewProvjera.TabIndex = 3;
            // 
            // dataGridViewError
            // 
            this.dataGridViewError.AllowUserToAddRows = false;
            this.dataGridViewError.AllowUserToDeleteRows = false;
            this.dataGridViewError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorID2,
            this.TV,
            this.Vrijeme2});
            this.dataGridViewError.Location = new System.Drawing.Point(260, 72);
            this.dataGridViewError.Name = "dataGridViewError";
            this.dataGridViewError.ReadOnly = true;
            this.dataGridViewError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewError.Size = new System.Drawing.Size(244, 361);
            this.dataGridViewError.TabIndex = 4;
            // 
            // ErrorID
            // 
            this.ErrorID.DataPropertyName = "ErrorID";
            this.ErrorID.HeaderText = "ErrorID";
            this.ErrorID.Name = "ErrorID";
            this.ErrorID.ReadOnly = true;
            this.ErrorID.Visible = false;
            // 
            // NazivTV
            // 
            this.NazivTV.DataPropertyName = "nazivTV";
            this.NazivTV.HeaderText = "TV";
            this.NazivTV.Name = "NazivTV";
            this.NazivTV.ReadOnly = true;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
            // 
            // ErrorID2
            // 
            this.ErrorID2.DataPropertyName = "ErrorID";
            this.ErrorID2.HeaderText = "ErrorID";
            this.ErrorID2.Name = "ErrorID2";
            this.ErrorID2.ReadOnly = true;
            this.ErrorID2.Visible = false;
            // 
            // TV
            // 
            this.TV.DataPropertyName = "nazivTV";
            this.TV.HeaderText = "TV";
            this.TV.Name = "TV";
            this.TV.ReadOnly = true;
            // 
            // Vrijeme2
            // 
            this.Vrijeme2.DataPropertyName = "Vrijeme";
            this.Vrijeme2.HeaderText = "Vrijeme";
            this.Vrijeme2.Name = "Vrijeme2";
            this.Vrijeme2.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obrisi error";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewProvjeraKasni
            // 
            this.dataGridViewProvjeraKasni.AllowUserToAddRows = false;
            this.dataGridViewProvjeraKasni.AllowUserToDeleteRows = false;
            this.dataGridViewProvjeraKasni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvjeraKasni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrorID3,
            this.TV3,
            this.Vrijeme3});
            this.dataGridViewProvjeraKasni.Location = new System.Drawing.Point(510, 72);
            this.dataGridViewProvjeraKasni.Name = "dataGridViewProvjeraKasni";
            this.dataGridViewProvjeraKasni.ReadOnly = true;
            this.dataGridViewProvjeraKasni.Size = new System.Drawing.Size(244, 361);
            this.dataGridViewProvjeraKasni.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Televizija nije provjerila api 2 sata";
            // 
            // ErrorID3
            // 
            this.ErrorID3.DataPropertyName = "ErrorID";
            this.ErrorID3.HeaderText = "ErrorID";
            this.ErrorID3.Name = "ErrorID3";
            this.ErrorID3.ReadOnly = true;
            this.ErrorID3.Visible = false;
            // 
            // TV3
            // 
            this.TV3.DataPropertyName = "nazivTV";
            this.TV3.HeaderText = "TV";
            this.TV3.Name = "TV3";
            this.TV3.ReadOnly = true;
            // 
            // Vrijeme3
            // 
            this.Vrijeme3.DataPropertyName = "Vrijeme";
            this.Vrijeme3.HeaderText = "Vrijeme";
            this.Vrijeme3.Name = "Vrijeme3";
            this.Vrijeme3.ReadOnly = true;
            // 
            // errorAndroidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewProvjeraKasni);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewError);
            this.Controls.Add(this.dataGridViewProvjera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "errorAndroidForm";
            this.Text = "errorAndroidForm";
            this.Load += new System.EventHandler(this.errorAndroidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvjera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvjeraKasni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewProvjera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridView dataGridViewError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewProvjeraKasni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme3;
        private System.Windows.Forms.Label label3;
    }
}