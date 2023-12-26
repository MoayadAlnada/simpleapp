namespace hafta3odevi
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
            this.txt_baslik = new System.Windows.Forms.Label();
            this.txt_adsoyad = new System.Windows.Forms.Label();
            this.txt_ogrno = new System.Windows.Forms.Label();
            this.txt_bolumadi = new System.Windows.Forms.Label();
            this.txtbx_adsoyad = new System.Windows.Forms.TextBox();
            this.txtbx_ogrno = new System.Windows.Forms.TextBox();
            this.txtbx_bolumadi = new System.Windows.Forms.TextBox();
            this.btn_ogrekle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_baslik2 = new System.Windows.Forms.Label();
            this.txt_hosgel = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.txtbx_ara = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_baslik
            // 
            this.txt_baslik.AutoSize = true;
            this.txt_baslik.Location = new System.Drawing.Point(35, 80);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(103, 13);
            this.txt_baslik.TabIndex = 0;
            this.txt_baslik.Text = "Öğrenci Kayıt Ekranı";
            this.txt_baslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.AutoSize = true;
            this.txt_adsoyad.Location = new System.Drawing.Point(35, 130);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.Size = new System.Drawing.Size(53, 13);
            this.txt_adsoyad.TabIndex = 1;
            this.txt_adsoyad.Text = "Ad-Soyad";
            // 
            // txt_ogrno
            // 
            this.txt_ogrno.AutoSize = true;
            this.txt_ogrno.Location = new System.Drawing.Point(35, 175);
            this.txt_ogrno.Name = "txt_ogrno";
            this.txt_ogrno.Size = new System.Drawing.Size(61, 13);
            this.txt_ogrno.TabIndex = 2;
            this.txt_ogrno.Text = "Öğrenci No";
            // 
            // txt_bolumadi
            // 
            this.txt_bolumadi.AutoSize = true;
            this.txt_bolumadi.Location = new System.Drawing.Point(35, 215);
            this.txt_bolumadi.Name = "txt_bolumadi";
            this.txt_bolumadi.Size = new System.Drawing.Size(54, 13);
            this.txt_bolumadi.TabIndex = 3;
            this.txt_bolumadi.Text = "Bölüm Adı";
            // 
            // txtbx_adsoyad
            // 
            this.txtbx_adsoyad.Location = new System.Drawing.Point(134, 127);
            this.txtbx_adsoyad.Name = "txtbx_adsoyad";
            this.txtbx_adsoyad.Size = new System.Drawing.Size(143, 20);
            this.txtbx_adsoyad.TabIndex = 4;
            this.txtbx_adsoyad.TextChanged += new System.EventHandler(this.txtbx_adsoyad_TextChanged);
            // 
            // txtbx_ogrno
            // 
            this.txtbx_ogrno.Location = new System.Drawing.Point(134, 168);
            this.txtbx_ogrno.Name = "txtbx_ogrno";
            this.txtbx_ogrno.Size = new System.Drawing.Size(143, 20);
            this.txtbx_ogrno.TabIndex = 4;
            this.txtbx_ogrno.TextChanged += new System.EventHandler(this.txtbx_ogrno_TextChanged);
            // 
            // txtbx_bolumadi
            // 
            this.txtbx_bolumadi.Location = new System.Drawing.Point(134, 208);
            this.txtbx_bolumadi.Name = "txtbx_bolumadi";
            this.txtbx_bolumadi.Size = new System.Drawing.Size(143, 20);
            this.txtbx_bolumadi.TabIndex = 4;
            this.txtbx_bolumadi.TextChanged += new System.EventHandler(this.txtbx_bolumadi_TextChanged);
            // 
            // btn_ogrekle
            // 
            this.btn_ogrekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ogrekle.Location = new System.Drawing.Point(134, 259);
            this.btn_ogrekle.Name = "btn_ogrekle";
            this.btn_ogrekle.Size = new System.Drawing.Size(143, 73);
            this.btn_ogrekle.TabIndex = 5;
            this.btn_ogrekle.Text = "Öğrenci Ekle";
            this.btn_ogrekle.UseVisualStyleBackColor = true;
            this.btn_ogrekle.Click += new System.EventHandler(this.btn_ogrekle_Click);
            // 
            // txt_baslik2
            // 
            this.txt_baslik2.AutoSize = true;
            this.txt_baslik2.Location = new System.Drawing.Point(415, 80);
            this.txt_baslik2.Name = "txt_baslik2";
            this.txt_baslik2.Size = new System.Drawing.Size(79, 13);
            this.txt_baslik2.TabIndex = 3;
            this.txt_baslik2.Text = "Öğrenci Bilgileri";
            // 
            // txt_hosgel
            // 
            this.txt_hosgel.AutoSize = true;
            this.txt_hosgel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hosgel.Location = new System.Drawing.Point(254, 9);
            this.txt_hosgel.Name = "txt_hosgel";
            this.txt_hosgel.Size = new System.Drawing.Size(259, 29);
            this.txt_hosgel.TabIndex = 3;
            this.txt_hosgel.Text = "Hafta 3\'e Hoşgeldiniz";
            this.txt_hosgel.Click += new System.EventHandler(this.txt_hosgel_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(547, 315);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(143, 28);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(572, 366);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(118, 20);
            this.btn_ara.TabIndex = 5;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_aktar
            // 
            this.btn_aktar.Location = new System.Drawing.Point(492, 116);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(143, 20);
            this.btn_aktar.TabIndex = 5;
            this.btn_aktar.Text = "Aktar";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // txtbx_ara
            // 
            this.txtbx_ara.Location = new System.Drawing.Point(435, 366);
            this.txtbx_ara.Name = "txtbx_ara";
            this.txtbx_ara.Size = new System.Drawing.Size(107, 20);
            this.txtbx_ara.TabIndex = 4;
            this.txtbx_ara.TextChanged += new System.EventHandler(this.txtbx_ara_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(435, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 134);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_ogrekle);
            this.Controls.Add(this.txtbx_ara);
            this.Controls.Add(this.txtbx_bolumadi);
            this.Controls.Add(this.txtbx_ogrno);
            this.Controls.Add(this.txtbx_adsoyad);
            this.Controls.Add(this.txt_hosgel);
            this.Controls.Add(this.txt_baslik2);
            this.Controls.Add(this.txt_bolumadi);
            this.Controls.Add(this.txt_ogrno);
            this.Controls.Add(this.txt_adsoyad);
            this.Controls.Add(this.txt_baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_baslik;
        private System.Windows.Forms.Label txt_adsoyad;
        private System.Windows.Forms.Label txt_ogrno;
        private System.Windows.Forms.Label txt_bolumadi;
        private System.Windows.Forms.TextBox txtbx_adsoyad;
        private System.Windows.Forms.TextBox txtbx_ogrno;
        private System.Windows.Forms.TextBox txtbx_bolumadi;
        private System.Windows.Forms.Button btn_ogrekle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label txt_baslik2;
        private System.Windows.Forms.Label txt_hosgel;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.TextBox txtbx_ara;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

