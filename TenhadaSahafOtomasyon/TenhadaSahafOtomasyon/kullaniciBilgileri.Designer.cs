namespace TenhadaSahafOtomasyon
{
    partial class kullaniciBilgileri
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
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kullanici_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.dukkan_txt = new System.Windows.Forms.TextBox();
            this.telNo_txt = new System.Windows.Forms.TextBox();
            this.geri_btn = new System.Windows.Forms.Button();
            this.kayitListesi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dukkanAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisPaneliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet3 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet3();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.girisPaneliTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet3TableAdapters.girisPaneliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kayitListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisPaneliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guncelle_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_btn.Location = new System.Drawing.Point(139, 390);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(194, 35);
            this.guncelle_btn.TabIndex = 5;
            this.guncelle_btn.Text = "Bilgilerimi Güncelle";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // kullanici_txt
            // 
            this.kullanici_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullanici_txt.BackColor = System.Drawing.SystemColors.Control;
            this.kullanici_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_txt.Location = new System.Drawing.Point(213, 121);
            this.kullanici_txt.Name = "kullanici_txt";
            this.kullanici_txt.Size = new System.Drawing.Size(120, 30);
            this.kullanici_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-posta";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dükkan İsmi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon Numarası";
            // 
            // sifre_txt
            // 
            this.sifre_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Control;
            this.sifre_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_txt.Location = new System.Drawing.Point(213, 171);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(120, 30);
            this.sifre_txt.TabIndex = 1;
            // 
            // mail_txt
            // 
            this.mail_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mail_txt.BackColor = System.Drawing.SystemColors.Control;
            this.mail_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail_txt.Location = new System.Drawing.Point(213, 229);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(120, 30);
            this.mail_txt.TabIndex = 2;
            // 
            // dukkan_txt
            // 
            this.dukkan_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dukkan_txt.BackColor = System.Drawing.SystemColors.Control;
            this.dukkan_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dukkan_txt.Location = new System.Drawing.Point(213, 292);
            this.dukkan_txt.Name = "dukkan_txt";
            this.dukkan_txt.Size = new System.Drawing.Size(120, 30);
            this.dukkan_txt.TabIndex = 3;
            // 
            // telNo_txt
            // 
            this.telNo_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telNo_txt.BackColor = System.Drawing.SystemColors.Control;
            this.telNo_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNo_txt.Location = new System.Drawing.Point(213, 340);
            this.telNo_txt.Name = "telNo_txt";
            this.telNo_txt.Size = new System.Drawing.Size(120, 30);
            this.telNo_txt.TabIndex = 4;
            // 
            // geri_btn
            // 
            this.geri_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.geri_btn.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.geri_32;
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri_btn.Location = new System.Drawing.Point(19, 12);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(36, 31);
            this.geri_btn.TabIndex = 38;
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // kayitListesi
            // 
            this.kayitListesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayitListesi.AutoGenerateColumns = false;
            this.kayitListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayitListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.dukkanAdiDataGridViewTextBoxColumn});
            this.kayitListesi.DataSource = this.girisPaneliBindingSource;
            this.kayitListesi.Location = new System.Drawing.Point(358, 69);
            this.kayitListesi.Name = "kayitListesi";
            this.kayitListesi.RowHeadersVisible = false;
            this.kayitListesi.RowHeadersWidth = 51;
            this.kayitListesi.RowTemplate.Height = 24;
            this.kayitListesi.Size = new System.Drawing.Size(396, 356);
            this.kayitListesi.TabIndex = 39;
            this.kayitListesi.DoubleClick += new System.EventHandler(this.kayitListesi_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "telefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "telefonNo";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dukkanAdiDataGridViewTextBoxColumn
            // 
            this.dukkanAdiDataGridViewTextBoxColumn.DataPropertyName = "dukkanAdi";
            this.dukkanAdiDataGridViewTextBoxColumn.HeaderText = "dukkanAdi";
            this.dukkanAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dukkanAdiDataGridViewTextBoxColumn.Name = "dukkanAdiDataGridViewTextBoxColumn";
            this.dukkanAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // girisPaneliBindingSource
            // 
            this.girisPaneliBindingSource.DataMember = "girisPaneli";
            this.girisPaneliBindingSource.DataSource = this.sahafOtomasyonuDataSet3;
            // 
            // sahafOtomasyonuDataSet3
            // 
            this.sahafOtomasyonuDataSet3.DataSetName = "SahafOtomasyonuDataSet3";
            this.sahafOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_txt
            // 
            this.id_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_txt.BackColor = System.Drawing.SystemColors.Control;
            this.id_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_txt.Location = new System.Drawing.Point(212, 71);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(120, 30);
            this.id_txt.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Kullanıcı id";
            // 
            // girisPaneliTableAdapter
            // 
            this.girisPaneliTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciBilgileri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.kitaplar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 503);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kayitListesi);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.telNo_txt);
            this.Controls.Add(this.dukkan_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanici_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guncelle_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullaniciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciBilgileri";
            this.Load += new System.EventHandler(this.kullaniciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayitListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisPaneliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanici_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.TextBox dukkan_txt;
        private System.Windows.Forms.TextBox telNo_txt;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.DataGridView kayitListesi;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label6;
        private SahafOtomasyonuDataSet3 sahafOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource girisPaneliBindingSource;
        private SahafOtomasyonuDataSet3TableAdapters.girisPaneliTableAdapter girisPaneliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dukkanAdiDataGridViewTextBoxColumn;
    }
}