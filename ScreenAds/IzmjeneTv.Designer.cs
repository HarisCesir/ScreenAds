namespace ScreenAds
{
    partial class IzmjeneTv
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.comboBoxGradovi = new System.Windows.Forms.ComboBox();
            this.comboBoxObjekti = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Tv-a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Objekat";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(98, 22);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.ReadOnly = true;
            this.textBoxNaziv.Size = new System.Drawing.Size(146, 20);
            this.textBoxNaziv.TabIndex = 3;
            // 
            // comboBoxGradovi
            // 
            this.comboBoxGradovi.FormattingEnabled = true;
            this.comboBoxGradovi.Location = new System.Drawing.Point(98, 48);
            this.comboBoxGradovi.Name = "comboBoxGradovi";
            this.comboBoxGradovi.Size = new System.Drawing.Size(146, 21);
            this.comboBoxGradovi.TabIndex = 4;
            this.comboBoxGradovi.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGradovi_Validating);
            // 
            // comboBoxObjekti
            // 
            this.comboBoxObjekti.FormattingEnabled = true;
            this.comboBoxObjekti.Location = new System.Drawing.Point(98, 79);
            this.comboBoxObjekti.Name = "comboBoxObjekti";
            this.comboBoxObjekti.Size = new System.Drawing.Size(146, 21);
            this.comboBoxObjekti.TabIndex = 5;
            this.comboBoxObjekti.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxObjekti_Validating);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sačuvaj izmjene";
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
            // IzmjeneTv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxObjekti);
            this.Controls.Add(this.comboBoxGradovi);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzmjeneTv";
            this.Text = "Izmjene televizija";
            this.Load += new System.EventHandler(this.IzmjeneTv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.ComboBox comboBoxGradovi;
        private System.Windows.Forms.ComboBox comboBoxObjekti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}