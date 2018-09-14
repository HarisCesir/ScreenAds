﻿namespace ScreenAds
{
    partial class TelevizijeForm
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
            this.comboBoxObjekat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGrad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazivTV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TelevizijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objekat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxObjekat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxGrad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNazivTV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj televiziju";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxObjekat
            // 
            this.comboBoxObjekat.FormattingEnabled = true;
            this.comboBoxObjekat.Location = new System.Drawing.Point(23, 148);
            this.comboBoxObjekat.Name = "comboBoxObjekat";
            this.comboBoxObjekat.Size = new System.Drawing.Size(161, 21);
            this.comboBoxObjekat.TabIndex = 5;
            this.comboBoxObjekat.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxObjekat_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv objekta";
            // 
            // comboBoxGrad
            // 
            this.comboBoxGrad.FormattingEnabled = true;
            this.comboBoxGrad.Location = new System.Drawing.Point(23, 88);
            this.comboBoxGrad.Name = "comboBoxGrad";
            this.comboBoxGrad.Size = new System.Drawing.Size(161, 21);
            this.comboBoxGrad.TabIndex = 3;
            this.comboBoxGrad.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGrad_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grad";
            // 
            // textBoxNazivTV
            // 
            this.textBoxNazivTV.Location = new System.Drawing.Point(23, 40);
            this.textBoxNazivTV.Name = "textBoxNazivTV";
            this.textBoxNazivTV.Size = new System.Drawing.Size(161, 20);
            this.textBoxNazivTV.TabIndex = 1;
            this.textBoxNazivTV.TextChanged += new System.EventHandler(this.textBoxNazivTV_TextChanged);
            this.textBoxNazivTV.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNazivTV_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
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
            this.TelevizijaID,
            this.Naziv,
            this.Grad,
            this.Objekat,
            this.Adresa});
            this.dataGridView1.Location = new System.Drawing.Point(268, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 305);
            this.dataGridView1.TabIndex = 1;
            // 
            // TelevizijaID
            // 
            this.TelevizijaID.DataPropertyName = "TelevizijaID";
            this.TelevizijaID.HeaderText = "TelevizijaID";
            this.TelevizijaID.Name = "TelevizijaID";
            this.TelevizijaID.ReadOnly = true;
            this.TelevizijaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "NazivTelevizije";
            this.Naziv.HeaderText = "Broj TV-a";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "NazivGrada";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Objekat
            // 
            this.Objekat.DataPropertyName = "NazivObjekta";
            this.Objekat.HeaderText = "Naziv objekta";
            this.Objekat.Name = "Objekat";
            this.Objekat.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "AdresaObjekta";
            this.Adresa.HeaderText = "Adresa objekta";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 15);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Obriši televiziju";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(396, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Izmjeni televiziju";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelevizijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 361);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelevizijeForm";
            this.Text = "Televizije";
            this.Load += new System.EventHandler(this.TelevizijeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxObjekat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazivTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelevizijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objekat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}