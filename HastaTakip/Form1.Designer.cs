namespace HastaTakip
{
    partial class Form1
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
            this.lblDogumYili = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.cmdCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.HastaEkle = new System.Windows.Forms.Button();
            this.Hesapla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toplamucret = new System.Windows.Forms.Label();
            this.datedogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yıl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndirimliUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // lblDogumYili
            // 
            this.lblDogumYili.AutoSize = true;
            this.lblDogumYili.Location = new System.Drawing.Point(9, 42);
            this.lblDogumYili.Name = "lblDogumYili";
            this.lblDogumYili.Size = new System.Drawing.Size(60, 13);
            this.lblDogumYili.TabIndex = 1;
            this.lblDogumYili.Text = "Doğum Yılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyeti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ücret:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(78, 5);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 4;
            // 
            // cmdCinsiyet
            // 
            this.cmdCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdCinsiyet.FormattingEnabled = true;
            this.cmdCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmdCinsiyet.Location = new System.Drawing.Point(290, 4);
            this.cmdCinsiyet.Name = "cmdCinsiyet";
            this.cmdCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmdCinsiyet.TabIndex = 6;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(290, 39);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 7;
            // 
            // HastaEkle
            // 
            this.HastaEkle.Location = new System.Drawing.Point(142, 82);
            this.HastaEkle.Name = "HastaEkle";
            this.HastaEkle.Size = new System.Drawing.Size(75, 23);
            this.HastaEkle.TabIndex = 8;
            this.HastaEkle.Text = "Hasta Ekle";
            this.HastaEkle.UseVisualStyleBackColor = true;
            this.HastaEkle.Click += new System.EventHandler(this.HastaEkle_Click);
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(290, 82);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(75, 23);
            this.Hesapla.TabIndex = 9;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adı,
            this.Yıl,
            this.Cinsiyet,
            this.Ucret,
            this.IndirimliUcret,
            this.Yas});
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // toplamucret
            // 
            this.toplamucret.AutoSize = true;
            this.toplamucret.Location = new System.Drawing.Point(360, 282);
            this.toplamucret.Name = "toplamucret";
            this.toplamucret.Size = new System.Drawing.Size(74, 13);
            this.toplamucret.TabIndex = 11;
            this.toplamucret.Text = "Toplam Ucret:";
            // 
            // datedogumtarihi
            // 
            this.datedogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedogumtarihi.Location = new System.Drawing.Point(75, 37);
            this.datedogumtarihi.Name = "datedogumtarihi";
            this.datedogumtarihi.Size = new System.Drawing.Size(103, 20);
            this.datedogumtarihi.TabIndex = 12;
            // 
            // Adı
            // 
            this.Adı.HeaderText = "Adı";
            this.Adı.Name = "Adı";
            // 
            // Yıl
            // 
            this.Yıl.HeaderText = "Dogum Yılı";
            this.Yıl.Name = "Yıl";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Width = 50;
            // 
            // Ucret
            // 
            this.Ucret.HeaderText = "Ücret";
            this.Ucret.Name = "Ucret";
            this.Ucret.Width = 70;
            // 
            // IndirimliUcret
            // 
            this.IndirimliUcret.HeaderText = "İndirimli Ücret";
            this.IndirimliUcret.Name = "IndirimliUcret";
            this.IndirimliUcret.Width = 70;
            // 
            // Yas
            // 
            this.Yas.HeaderText = "Yaş";
            this.Yas.Name = "Yas";
            this.Yas.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 304);
            this.Controls.Add(this.datedogumtarihi);
            this.Controls.Add(this.toplamucret);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.HastaEkle);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.cmdCinsiyet);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDogumYili);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDogumYili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.ComboBox cmdCinsiyet;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Button HastaEkle;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label toplamucret;
        private System.Windows.Forms.DateTimePicker datedogumtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yıl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndirimliUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
    }
}

