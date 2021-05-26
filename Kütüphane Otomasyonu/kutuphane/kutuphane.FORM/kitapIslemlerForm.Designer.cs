namespace kutuphane.FORM
{
    partial class kitapIslemlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapIslemlerForm));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rtxt_ozet = new System.Windows.Forms.RichTextBox();
            this.txt_rafNo = new System.Windows.Forms.TextBox();
            this.txt_stokS = new System.Windows.Forms.TextBox();
            this.lbl_ozet = new System.Windows.Forms.Label();
            this.lbl_rafNo = new System.Windows.Forms.Label();
            this.lbl_stokS = new System.Windows.Forms.Label();
            this.mtxt_YayinT = new System.Windows.Forms.MaskedTextBox();
            this.cmb_k = new System.Windows.Forms.ComboBox();
            this.cmb_y = new System.Windows.Forms.ComboBox();
            this.cmb_ye = new System.Windows.Forms.ComboBox();
            this.txt_sayfaS = new System.Windows.Forms.TextBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.lbl_yayinEvi = new System.Windows.Forms.Label();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.lblkitapSil = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_ısbn = new System.Windows.Forms.TextBox();
            this.lbl_sayfaS = new System.Windows.Forms.Label();
            this.lbl_yayinT = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_ısbn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rtxt_ozet
            // 
            this.rtxt_ozet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rtxt_ozet.Location = new System.Drawing.Point(409, 246);
            this.rtxt_ozet.Name = "rtxt_ozet";
            this.rtxt_ozet.Size = new System.Drawing.Size(175, 96);
            this.rtxt_ozet.TabIndex = 109;
            this.rtxt_ozet.Text = "";
            // 
            // txt_rafNo
            // 
            this.txt_rafNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_rafNo.Location = new System.Drawing.Point(409, 207);
            this.txt_rafNo.Name = "txt_rafNo";
            this.txt_rafNo.Size = new System.Drawing.Size(175, 25);
            this.txt_rafNo.TabIndex = 108;
            // 
            // txt_stokS
            // 
            this.txt_stokS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_stokS.Location = new System.Drawing.Point(409, 169);
            this.txt_stokS.Name = "txt_stokS";
            this.txt_stokS.Size = new System.Drawing.Size(175, 25);
            this.txt_stokS.TabIndex = 107;
            // 
            // lbl_ozet
            // 
            this.lbl_ozet.AutoSize = true;
            this.lbl_ozet.Location = new System.Drawing.Point(362, 249);
            this.lbl_ozet.Name = "lbl_ozet";
            this.lbl_ozet.Size = new System.Drawing.Size(43, 17);
            this.lbl_ozet.TabIndex = 106;
            this.lbl_ozet.Text = "Özet :";
            // 
            // lbl_rafNo
            // 
            this.lbl_rafNo.AutoSize = true;
            this.lbl_rafNo.Location = new System.Drawing.Point(346, 210);
            this.lbl_rafNo.Name = "lbl_rafNo";
            this.lbl_rafNo.Size = new System.Drawing.Size(59, 17);
            this.lbl_rafNo.TabIndex = 105;
            this.lbl_rafNo.Text = "Raf No :";
            // 
            // lbl_stokS
            // 
            this.lbl_stokS.AutoSize = true;
            this.lbl_stokS.Location = new System.Drawing.Point(326, 172);
            this.lbl_stokS.Name = "lbl_stokS";
            this.lbl_stokS.Size = new System.Drawing.Size(79, 17);
            this.lbl_stokS.TabIndex = 104;
            this.lbl_stokS.Text = "Stok Sayısı :";
            // 
            // mtxt_YayinT
            // 
            this.mtxt_YayinT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mtxt_YayinT.Location = new System.Drawing.Point(122, 207);
            this.mtxt_YayinT.Mask = "0000";
            this.mtxt_YayinT.Name = "mtxt_YayinT";
            this.mtxt_YayinT.Size = new System.Drawing.Size(175, 25);
            this.mtxt_YayinT.TabIndex = 103;
            this.mtxt_YayinT.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_k
            // 
            this.cmb_k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmb_k.FormattingEnabled = true;
            this.cmb_k.Location = new System.Drawing.Point(122, 284);
            this.cmb_k.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_k.Name = "cmb_k";
            this.cmb_k.Size = new System.Drawing.Size(175, 25);
            this.cmb_k.TabIndex = 102;
            // 
            // cmb_y
            // 
            this.cmb_y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmb_y.FormattingEnabled = true;
            this.cmb_y.Location = new System.Drawing.Point(409, 129);
            this.cmb_y.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_y.Name = "cmb_y";
            this.cmb_y.Size = new System.Drawing.Size(175, 25);
            this.cmb_y.TabIndex = 101;
            // 
            // cmb_ye
            // 
            this.cmb_ye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmb_ye.FormattingEnabled = true;
            this.cmb_ye.Location = new System.Drawing.Point(122, 322);
            this.cmb_ye.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ye.Name = "cmb_ye";
            this.cmb_ye.Size = new System.Drawing.Size(175, 25);
            this.cmb_ye.TabIndex = 100;
            // 
            // txt_sayfaS
            // 
            this.txt_sayfaS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_sayfaS.Location = new System.Drawing.Point(122, 245);
            this.txt_sayfaS.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sayfaS.Name = "txt_sayfaS";
            this.txt_sayfaS.Size = new System.Drawing.Size(175, 25);
            this.txt_sayfaS.TabIndex = 99;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.Location = new System.Drawing.Point(47, 287);
            this.lbl_kategori.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(66, 17);
            this.lbl_kategori.TabIndex = 98;
            this.lbl_kategori.Text = "Kategori :";
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.Location = new System.Drawing.Point(356, 132);
            this.lbl_yazar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(49, 17);
            this.lbl_yazar.TabIndex = 97;
            this.lbl_yazar.Text = "Yazar :";
            // 
            // lbl_yayinEvi
            // 
            this.lbl_yayinEvi.AutoSize = true;
            this.lbl_yayinEvi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yayinEvi.Location = new System.Drawing.Point(47, 327);
            this.lbl_yayinEvi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_yayinEvi.Name = "lbl_yayinEvi";
            this.lbl_yayinEvi.Size = new System.Drawing.Size(71, 17);
            this.lbl_yayinEvi.TabIndex = 96;
            this.lbl_yayinEvi.Text = "Yayın Evi :";
            // 
            // txtSil
            // 
            this.txtSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSil.Location = new System.Drawing.Point(247, 82);
            this.txtSil.Margin = new System.Windows.Forms.Padding(5);
            this.txtSil.MaxLength = 6;
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(175, 25);
            this.txtSil.TabIndex = 95;
            // 
            // lblkitapSil
            // 
            this.lblkitapSil.AutoSize = true;
            this.lblkitapSil.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkitapSil.Location = new System.Drawing.Point(23, 85);
            this.lblkitapSil.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblkitapSil.Name = "lblkitapSil";
            this.lblkitapSil.Size = new System.Drawing.Size(212, 17);
            this.lblkitapSil.TabIndex = 94;
            this.lblkitapSil.Text = "Silinecek Kitabın ISBN Numarası :";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(264, 367);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 40);
            this.btn_guncelle.TabIndex = 93;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(443, 73);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 40);
            this.btn_sil.TabIndex = 92;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(443, 367);
            this.btn_listele.Margin = new System.Windows.Forms.Padding(5);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(100, 40);
            this.btn_listele.TabIndex = 91;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(86, 367);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 40);
            this.btn_ekle.TabIndex = 90;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 417);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 170);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_ad
            // 
            this.txt_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_ad.Location = new System.Drawing.Point(122, 169);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(175, 25);
            this.txt_ad.TabIndex = 88;
            // 
            // txt_ısbn
            // 
            this.txt_ısbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_ısbn.Location = new System.Drawing.Point(122, 129);
            this.txt_ısbn.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ısbn.MaxLength = 6;
            this.txt_ısbn.Name = "txt_ısbn";
            this.txt_ısbn.Size = new System.Drawing.Size(175, 25);
            this.txt_ısbn.TabIndex = 87;
            // 
            // lbl_sayfaS
            // 
            this.lbl_sayfaS.AutoSize = true;
            this.lbl_sayfaS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayfaS.Location = new System.Drawing.Point(28, 246);
            this.lbl_sayfaS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_sayfaS.Name = "lbl_sayfaS";
            this.lbl_sayfaS.Size = new System.Drawing.Size(87, 17);
            this.lbl_sayfaS.TabIndex = 86;
            this.lbl_sayfaS.Text = "Sayfa Sayısı :";
            // 
            // lbl_yayinT
            // 
            this.lbl_yayinT.AutoSize = true;
            this.lbl_yayinT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yayinT.Location = new System.Drawing.Point(30, 210);
            this.lbl_yayinT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_yayinT.Name = "lbl_yayinT";
            this.lbl_yayinT.Size = new System.Drawing.Size(85, 17);
            this.lbl_yayinT.TabIndex = 85;
            this.lbl_yayinT.Text = "Yayın Tarihi :";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(76, 172);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(36, 17);
            this.lbl_ad.TabIndex = 84;
            this.lbl_ad.Text = "Adı :";
            // 
            // lbl_ısbn
            // 
            this.lbl_ısbn.AutoSize = true;
            this.lbl_ısbn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ısbn.Location = new System.Drawing.Point(42, 132);
            this.lbl_ısbn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ısbn.Name = "lbl_ısbn";
            this.lbl_ısbn.Size = new System.Drawing.Size(71, 17);
            this.lbl_ısbn.TabIndex = 83;
            this.lbl_ısbn.Text = "ISBN No :";
            // 
            // kitapIslemlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::kutuphane.FORM.Properties.Resources.kitap_banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(621, 601);
            this.Controls.Add(this.rtxt_ozet);
            this.Controls.Add(this.txt_rafNo);
            this.Controls.Add(this.txt_stokS);
            this.Controls.Add(this.lbl_ozet);
            this.Controls.Add(this.lbl_rafNo);
            this.Controls.Add(this.lbl_stokS);
            this.Controls.Add(this.mtxt_YayinT);
            this.Controls.Add(this.cmb_k);
            this.Controls.Add(this.cmb_y);
            this.Controls.Add(this.cmb_ye);
            this.Controls.Add(this.txt_sayfaS);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.lbl_yayinEvi);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.lblkitapSil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_ısbn);
            this.Controls.Add(this.lbl_sayfaS);
            this.Controls.Add(this.lbl_yayinT);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_ısbn);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kitapIslemlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.kitapIslemlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.RichTextBox rtxt_ozet;
        private System.Windows.Forms.TextBox txt_rafNo;
        private System.Windows.Forms.TextBox txt_stokS;
        private System.Windows.Forms.Label lbl_ozet;
        private System.Windows.Forms.Label lbl_rafNo;
        private System.Windows.Forms.Label lbl_stokS;
        private System.Windows.Forms.MaskedTextBox mtxt_YayinT;
        private System.Windows.Forms.ComboBox cmb_k;
        private System.Windows.Forms.ComboBox cmb_y;
        private System.Windows.Forms.ComboBox cmb_ye;
        private System.Windows.Forms.TextBox txt_sayfaS;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.Label lbl_yayinEvi;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.Label lblkitapSil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_ısbn;
        private System.Windows.Forms.Label lbl_sayfaS;
        private System.Windows.Forms.Label lbl_yayinT;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_ısbn;
    }
}