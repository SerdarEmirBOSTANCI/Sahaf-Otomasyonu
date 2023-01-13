namespace TenhadaSahafOtomasyon
{
    partial class oduncVer
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
            this.kitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isimKayit = new System.Windows.Forms.TextBox();
            this.yayinevi = new System.Windows.Forms.TextBox();
            this.yazarAd = new System.Windows.Forms.TextBox();
            this.kitapOduncVer = new System.Windows.Forms.Button();
            this.kitapIadeAl = new System.Windows.Forms.Button();
            this.kitaplarListesi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet2 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet2();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet();
            this.raf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kitaplarTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSetTableAdapters.kitaplarTableAdapter();
            this.sahafOtomasyonuDataSet1 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet1();
            this.oduncKitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oduncKitapTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet1TableAdapters.oduncKitapTableAdapter();
            this.oduncKitapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oduncKitapBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.oduncKitapTableAdapter1 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet2TableAdapters.oduncKitapTableAdapter();
            this.oduncKitaplar = new System.Windows.Forms.DataGridView();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncKitapBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarTableAdapter1 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet2TableAdapters.kitaplarTableAdapter();
            this.geri_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(838, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı";
            // 
            // kitapAd
            // 
            this.kitapAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kitapAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kitapAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAd.Location = new System.Drawing.Point(953, 108);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(168, 30);
            this.kitapAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(838, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(846, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayınevi";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(787, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ödünç Alan Kişi";
            // 
            // isimKayit
            // 
            this.isimKayit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isimKayit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.isimKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimKayit.Location = new System.Drawing.Point(953, 310);
            this.isimKayit.Name = "isimKayit";
            this.isimKayit.Size = new System.Drawing.Size(142, 30);
            this.isimKayit.TabIndex = 4;
            // 
            // yayinevi
            // 
            this.yayinevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yayinevi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yayinevi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayinevi.Location = new System.Drawing.Point(953, 212);
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Size = new System.Drawing.Size(142, 30);
            this.yayinevi.TabIndex = 2;
            // 
            // yazarAd
            // 
            this.yazarAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yazarAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yazarAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazarAd.Location = new System.Drawing.Point(953, 158);
            this.yazarAd.Name = "yazarAd";
            this.yazarAd.Size = new System.Drawing.Size(168, 30);
            this.yazarAd.TabIndex = 1;
            // 
            // kitapOduncVer
            // 
            this.kitapOduncVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kitapOduncVer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapOduncVer.Location = new System.Drawing.Point(953, 364);
            this.kitapOduncVer.Name = "kitapOduncVer";
            this.kitapOduncVer.Size = new System.Drawing.Size(103, 39);
            this.kitapOduncVer.TabIndex = 5;
            this.kitapOduncVer.Text = "Ödünç Ver";
            this.kitapOduncVer.UseVisualStyleBackColor = true;
            this.kitapOduncVer.Click += new System.EventHandler(this.kitapOduncVer_Click);
            // 
            // kitapIadeAl
            // 
            this.kitapIadeAl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kitapIadeAl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapIadeAl.Location = new System.Drawing.Point(953, 420);
            this.kitapIadeAl.Name = "kitapIadeAl";
            this.kitapIadeAl.Size = new System.Drawing.Size(103, 39);
            this.kitapIadeAl.TabIndex = 6;
            this.kitapIadeAl.Text = "İade Al";
            this.kitapIadeAl.UseVisualStyleBackColor = true;
            this.kitapIadeAl.Click += new System.EventHandler(this.kitapIadeAl_Click);
            // 
            // kitaplarListesi
            // 
            this.kitaplarListesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kitaplarListesi.AutoGenerateColumns = false;
            this.kitaplarListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplarListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.rafDataGridViewTextBoxColumn});
            this.kitaplarListesi.DataSource = this.kitaplarBindingSource1;
            this.kitaplarListesi.Location = new System.Drawing.Point(12, 54);
            this.kitaplarListesi.Name = "kitaplarListesi";
            this.kitaplarListesi.RowHeadersVisible = false;
            this.kitaplarListesi.RowHeadersWidth = 51;
            this.kitaplarListesi.RowTemplate.Height = 24;
            this.kitaplarListesi.Size = new System.Drawing.Size(765, 231);
            this.kitaplarListesi.TabIndex = 11;
            this.kitaplarListesi.DoubleClick += new System.EventHandler(this.kitaplarListesi_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.Width = 200;
            // 
            // yazarAdiDataGridViewTextBoxColumn
            // 
            this.yazarAdiDataGridViewTextBoxColumn.DataPropertyName = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            this.yazarAdiDataGridViewTextBoxColumn.Width = 200;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "yayinevi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "yayinevi";
            this.yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            this.yayineviDataGridViewTextBoxColumn.Width = 175;
            // 
            // rafDataGridViewTextBoxColumn
            // 
            this.rafDataGridViewTextBoxColumn.DataPropertyName = "raf";
            this.rafDataGridViewTextBoxColumn.HeaderText = "raf";
            this.rafDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rafDataGridViewTextBoxColumn.Name = "rafDataGridViewTextBoxColumn";
            this.rafDataGridViewTextBoxColumn.Width = 60;
            // 
            // kitaplarBindingSource1
            // 
            this.kitaplarBindingSource1.DataMember = "kitaplar";
            this.kitaplarBindingSource1.DataSource = this.sahafOtomasyonuDataSet2;
            // 
            // sahafOtomasyonuDataSet2
            // 
            this.sahafOtomasyonuDataSet2.DataSetName = "SahafOtomasyonuDataSet2";
            this.sahafOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.sahafOtomasyonuDataSet;
            // 
            // sahafOtomasyonuDataSet
            // 
            this.sahafOtomasyonuDataSet.DataSetName = "SahafOtomasyonuDataSet";
            this.sahafOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raf
            // 
            this.raf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.raf.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raf.Location = new System.Drawing.Point(953, 262);
            this.raf.Name = "raf";
            this.raf.Size = new System.Drawing.Size(56, 30);
            this.raf.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(882, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Raf";
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // sahafOtomasyonuDataSet1
            // 
            this.sahafOtomasyonuDataSet1.DataSetName = "SahafOtomasyonuDataSet1";
            this.sahafOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oduncKitapBindingSource
            // 
            this.oduncKitapBindingSource.DataMember = "oduncKitap";
            this.oduncKitapBindingSource.DataSource = this.sahafOtomasyonuDataSet1;
            // 
            // oduncKitapTableAdapter
            // 
            this.oduncKitapTableAdapter.ClearBeforeFill = true;
            // 
            // oduncKitapBindingSource1
            // 
            this.oduncKitapBindingSource1.DataMember = "oduncKitap";
            this.oduncKitapBindingSource1.DataSource = this.sahafOtomasyonuDataSet1;
            // 
            // oduncKitapBindingSource2
            // 
            this.oduncKitapBindingSource2.DataMember = "oduncKitap";
            this.oduncKitapBindingSource2.DataSource = this.sahafOtomasyonuDataSet2;
            // 
            // oduncKitapTableAdapter1
            // 
            this.oduncKitapTableAdapter1.ClearBeforeFill = true;
            // 
            // oduncKitaplar
            // 
            this.oduncKitaplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oduncKitaplar.AutoGenerateColumns = false;
            this.oduncKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isimDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn1,
            this.yazarAdiDataGridViewTextBoxColumn1,
            this.yayineviDataGridViewTextBoxColumn1,
            this.rafDataGridViewTextBoxColumn1});
            this.oduncKitaplar.DataSource = this.oduncKitapBindingSource3;
            this.oduncKitaplar.Location = new System.Drawing.Point(12, 310);
            this.oduncKitaplar.Name = "oduncKitaplar";
            this.oduncKitaplar.RowHeadersVisible = false;
            this.oduncKitaplar.RowHeadersWidth = 51;
            this.oduncKitaplar.RowTemplate.Height = 24;
            this.oduncKitaplar.Size = new System.Drawing.Size(765, 231);
            this.oduncKitaplar.TabIndex = 14;
            this.oduncKitaplar.DoubleClick += new System.EventHandler(this.oduncKitaplar_DoubleClick);
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "Ödünç Alan";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn1
            // 
            this.kitapAdiDataGridViewTextBoxColumn1.DataPropertyName = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn1.HeaderText = "Kitap Adı";
            this.kitapAdiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn1.Name = "kitapAdiDataGridViewTextBoxColumn1";
            this.kitapAdiDataGridViewTextBoxColumn1.Width = 200;
            // 
            // yazarAdiDataGridViewTextBoxColumn1
            // 
            this.yazarAdiDataGridViewTextBoxColumn1.DataPropertyName = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn1.HeaderText = "Yazar Adı";
            this.yazarAdiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.yazarAdiDataGridViewTextBoxColumn1.Name = "yazarAdiDataGridViewTextBoxColumn1";
            this.yazarAdiDataGridViewTextBoxColumn1.Width = 200;
            // 
            // yayineviDataGridViewTextBoxColumn1
            // 
            this.yayineviDataGridViewTextBoxColumn1.DataPropertyName = "yayinevi";
            this.yayineviDataGridViewTextBoxColumn1.HeaderText = "Yayınevi";
            this.yayineviDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn1.Name = "yayineviDataGridViewTextBoxColumn1";
            this.yayineviDataGridViewTextBoxColumn1.Width = 175;
            // 
            // rafDataGridViewTextBoxColumn1
            // 
            this.rafDataGridViewTextBoxColumn1.DataPropertyName = "raf";
            this.rafDataGridViewTextBoxColumn1.HeaderText = "Raf";
            this.rafDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.rafDataGridViewTextBoxColumn1.Name = "rafDataGridViewTextBoxColumn1";
            this.rafDataGridViewTextBoxColumn1.Width = 60;
            // 
            // oduncKitapBindingSource3
            // 
            this.oduncKitapBindingSource3.DataMember = "oduncKitap";
            this.oduncKitapBindingSource3.DataSource = this.sahafOtomasyonuDataSet2BindingSource;
            // 
            // sahafOtomasyonuDataSet2BindingSource
            // 
            this.sahafOtomasyonuDataSet2BindingSource.DataSource = this.sahafOtomasyonuDataSet2;
            this.sahafOtomasyonuDataSet2BindingSource.Position = 0;
            // 
            // kitaplarTableAdapter1
            // 
            this.kitaplarTableAdapter1.ClearBeforeFill = true;
            // 
            // geri_btn
            // 
            this.geri_btn.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.geri_32;
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri_btn.Location = new System.Drawing.Point(12, 12);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(36, 31);
            this.geri_btn.TabIndex = 7;
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // oduncVer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.hareketler;
            this.ClientSize = new System.Drawing.Size(1174, 616);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.oduncKitaplar);
            this.Controls.Add(this.raf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kitaplarListesi);
            this.Controls.Add(this.kitapIadeAl);
            this.Controls.Add(this.kitapOduncVer);
            this.Controls.Add(this.yazarAd);
            this.Controls.Add(this.yayinevi);
            this.Controls.Add(this.isimKayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitapAd);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oduncVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oduncVer";
            this.Load += new System.EventHandler(this.oduncVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncKitapBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isimKayit;
        private System.Windows.Forms.TextBox yayinevi;
        private System.Windows.Forms.TextBox yazarAd;
        private System.Windows.Forms.Button kitapOduncVer;
        private System.Windows.Forms.Button kitapIadeAl;
        private System.Windows.Forms.DataGridView kitaplarListesi;
        private System.Windows.Forms.TextBox raf;
        private System.Windows.Forms.Label label5;
        private SahafOtomasyonuDataSet sahafOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private SahafOtomasyonuDataSetTableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafDataGridViewTextBoxColumn;
        private SahafOtomasyonuDataSet1 sahafOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource oduncKitapBindingSource;
        private SahafOtomasyonuDataSet1TableAdapters.oduncKitapTableAdapter oduncKitapTableAdapter;
        private System.Windows.Forms.BindingSource oduncKitapBindingSource1;
        private SahafOtomasyonuDataSet2 sahafOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource oduncKitapBindingSource2;
        private SahafOtomasyonuDataSet2TableAdapters.oduncKitapTableAdapter oduncKitapTableAdapter1;
        private System.Windows.Forms.DataGridView oduncKitaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource oduncKitapBindingSource3;
        private System.Windows.Forms.BindingSource sahafOtomasyonuDataSet2BindingSource;
        private System.Windows.Forms.BindingSource kitaplarBindingSource1;
        private SahafOtomasyonuDataSet2TableAdapters.kitaplarTableAdapter kitaplarTableAdapter1;
        private System.Windows.Forms.Button geri_btn;
    }
}