namespace TenhadaSahafOtomasyon
{
    partial class kitaplar
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
            this.kitapSil = new System.Windows.Forms.Button();
            this.kitapSat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_kitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_fiyat = new System.Windows.Forms.TextBox();
            this.Txt_yayinevi = new System.Windows.Forms.TextBox();
            this.Txt_yazarAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_ozet = new System.Windows.Forms.TextBox();
            this.bilgiGüncelle = new System.Windows.Forms.Button();
            this.aramaCubugu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.sahafOtomasyonuDataSet = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSetTableAdapters.kitaplarTableAdapter();
            this.kitapListesi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satmaFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satinAlmaFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.özet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Txt_kitapTuru = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_raf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_resim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_satinAlmaFiyati = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kitapTuruAra = new System.Windows.Forms.ComboBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resim_btn = new System.Windows.Forms.Button();
            this.kitapResmi = new System.Windows.Forms.PictureBox();
            this.geri_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapSil
            // 
            this.kitapSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapSil.Location = new System.Drawing.Point(969, 498);
            this.kitapSil.Name = "kitapSil";
            this.kitapSil.Size = new System.Drawing.Size(162, 29);
            this.kitapSil.TabIndex = 14;
            this.kitapSil.Text = "Kitabı Sil";
            this.kitapSil.UseVisualStyleBackColor = true;
            this.kitapSil.Click += new System.EventHandler(this.kitapSil_Click);
            // 
            // kitapSat
            // 
            this.kitapSat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapSat.Location = new System.Drawing.Point(801, 498);
            this.kitapSat.Name = "kitapSat";
            this.kitapSat.Size = new System.Drawing.Size(162, 29);
            this.kitapSat.TabIndex = 13;
            this.kitapSat.Text = "Kitabı Sat";
            this.kitapSat.UseVisualStyleBackColor = true;
            this.kitapSat.Click += new System.EventHandler(this.kitapSat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(752, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitap Adı";
            // 
            // Txt_kitapAdi
            // 
            this.Txt_kitapAdi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_kitapAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_kitapAdi.Location = new System.Drawing.Point(844, 57);
            this.Txt_kitapAdi.Name = "Txt_kitapAdi";
            this.Txt_kitapAdi.Size = new System.Drawing.Size(228, 30);
            this.Txt_kitapAdi.TabIndex = 3;
            this.Txt_kitapAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(751, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yazar Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(759, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yayınevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(934, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiyat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txt_fiyat
            // 
            this.Txt_fiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_fiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_fiyat.Location = new System.Drawing.Point(987, 202);
            this.Txt_fiyat.Name = "Txt_fiyat";
            this.Txt_fiyat.Size = new System.Drawing.Size(85, 30);
            this.Txt_fiyat.TabIndex = 10;
            // 
            // Txt_yayinevi
            // 
            this.Txt_yayinevi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_yayinevi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_yayinevi.Location = new System.Drawing.Point(844, 129);
            this.Txt_yayinevi.Name = "Txt_yayinevi";
            this.Txt_yayinevi.Size = new System.Drawing.Size(228, 30);
            this.Txt_yayinevi.TabIndex = 5;
            // 
            // Txt_yazarAdi
            // 
            this.Txt_yazarAdi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_yazarAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_yazarAdi.Location = new System.Drawing.Point(844, 93);
            this.Txt_yazarAdi.Name = "Txt_yazarAdi";
            this.Txt_yazarAdi.Size = new System.Drawing.Size(228, 30);
            this.Txt_yazarAdi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(785, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Özet";
            // 
            // Txt_ozet
            // 
            this.Txt_ozet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_ozet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_ozet.Location = new System.Drawing.Point(844, 282);
            this.Txt_ozet.Multiline = true;
            this.Txt_ozet.Name = "Txt_ozet";
            this.Txt_ozet.Size = new System.Drawing.Size(480, 190);
            this.Txt_ozet.TabIndex = 12;
            // 
            // bilgiGüncelle
            // 
            this.bilgiGüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiGüncelle.Location = new System.Drawing.Point(1137, 498);
            this.bilgiGüncelle.Name = "bilgiGüncelle";
            this.bilgiGüncelle.Size = new System.Drawing.Size(187, 29);
            this.bilgiGüncelle.TabIndex = 15;
            this.bilgiGüncelle.Text = "Bilgileri Güncelle";
            this.bilgiGüncelle.UseVisualStyleBackColor = true;
            this.bilgiGüncelle.Click += new System.EventHandler(this.bilgiGüncelle_Click);
            // 
            // aramaCubugu
            // 
            this.aramaCubugu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.aramaCubugu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaCubugu.Location = new System.Drawing.Point(72, 54);
            this.aramaCubugu.Name = "aramaCubugu";
            this.aramaCubugu.Size = new System.Drawing.Size(298, 30);
            this.aramaCubugu.TabIndex = 0;
            this.aramaCubugu.TextChanged += new System.EventHandler(this.aramaCubugu_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ara";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sahafOtomasyonuDataSet
            // 
            this.sahafOtomasyonuDataSet.DataSetName = "SahafOtomasyonuDataSet";
            this.sahafOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.sahafOtomasyonuDataSet;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // kitapListesi
            // 
            this.kitapListesi.AutoGenerateColumns = false;
            this.kitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarAdiDataGridViewTextBoxColumn,
            this.yayineviDataGridViewTextBoxColumn,
            this.kitapTuruDataGridViewTextBoxColumn,
            this.rafDataGridViewTextBoxColumn,
            this.satmaFiyati,
            this.satinAlmaFiyati,
            this.resim,
            this.özet});
            this.kitapListesi.DataSource = this.kitaplarBindingSource1;
            this.kitapListesi.Location = new System.Drawing.Point(41, 96);
            this.kitapListesi.Name = "kitapListesi";
            this.kitapListesi.RowHeadersVisible = false;
            this.kitapListesi.RowHeadersWidth = 51;
            this.kitapListesi.RowTemplate.Height = 24;
            this.kitapListesi.Size = new System.Drawing.Size(704, 417);
            this.kitapListesi.TabIndex = 21;
            this.kitapListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.kitapListesi.DoubleClick += new System.EventHandler(this.kitapListesi_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "kitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapAdiDataGridViewTextBoxColumn.Width = 200;
            // 
            // yazarAdiDataGridViewTextBoxColumn
            // 
            this.yazarAdiDataGridViewTextBoxColumn.DataPropertyName = "yazarAdi";
            this.yazarAdiDataGridViewTextBoxColumn.HeaderText = "Yazar Adı";
            this.yazarAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarAdiDataGridViewTextBoxColumn.Name = "yazarAdiDataGridViewTextBoxColumn";
            this.yazarAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.yazarAdiDataGridViewTextBoxColumn.Width = 200;
            // 
            // yayineviDataGridViewTextBoxColumn
            // 
            this.yayineviDataGridViewTextBoxColumn.DataPropertyName = "yayinevi";
            this.yayineviDataGridViewTextBoxColumn.HeaderText = "Yayınevi";
            this.yayineviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviDataGridViewTextBoxColumn.Name = "yayineviDataGridViewTextBoxColumn";
            this.yayineviDataGridViewTextBoxColumn.ReadOnly = true;
            this.yayineviDataGridViewTextBoxColumn.Width = 110;
            // 
            // kitapTuruDataGridViewTextBoxColumn
            // 
            this.kitapTuruDataGridViewTextBoxColumn.DataPropertyName = "kitapTuru";
            this.kitapTuruDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.kitapTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapTuruDataGridViewTextBoxColumn.Name = "kitapTuruDataGridViewTextBoxColumn";
            this.kitapTuruDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapTuruDataGridViewTextBoxColumn.Width = 90;
            // 
            // rafDataGridViewTextBoxColumn
            // 
            this.rafDataGridViewTextBoxColumn.DataPropertyName = "raf";
            this.rafDataGridViewTextBoxColumn.HeaderText = "Raf";
            this.rafDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rafDataGridViewTextBoxColumn.Name = "rafDataGridViewTextBoxColumn";
            this.rafDataGridViewTextBoxColumn.ReadOnly = true;
            this.rafDataGridViewTextBoxColumn.Width = 50;
            // 
            // satmaFiyati
            // 
            this.satmaFiyati.DataPropertyName = "satmaFiyati";
            this.satmaFiyati.HeaderText = "Satış Fiyatı";
            this.satmaFiyati.MinimumWidth = 6;
            this.satmaFiyati.Name = "satmaFiyati";
            this.satmaFiyati.Width = 125;
            // 
            // satinAlmaFiyati
            // 
            this.satinAlmaFiyati.DataPropertyName = "satinAlmaFiyati";
            this.satinAlmaFiyati.HeaderText = "Satın Alınan Fiyat";
            this.satinAlmaFiyati.MinimumWidth = 6;
            this.satinAlmaFiyati.Name = "satinAlmaFiyati";
            this.satinAlmaFiyati.Width = 125;
            // 
            // resim
            // 
            this.resim.DataPropertyName = "resim";
            this.resim.HeaderText = "Resim";
            this.resim.MinimumWidth = 6;
            this.resim.Name = "resim";
            this.resim.Width = 125;
            // 
            // özet
            // 
            this.özet.DataPropertyName = "özet";
            this.özet.HeaderText = "Özet";
            this.özet.MinimumWidth = 6;
            this.özet.Name = "özet";
            this.özet.Width = 125;
            // 
            // kitaplarBindingSource1
            // 
            this.kitaplarBindingSource1.DataMember = "kitaplar";
            this.kitaplarBindingSource1.DataSource = this.sahafOtomasyonuDataSet;
            // 
            // Txt_kitapTuru
            // 
            this.Txt_kitapTuru.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_kitapTuru.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_kitapTuru.Location = new System.Drawing.Point(844, 165);
            this.Txt_kitapTuru.Name = "Txt_kitapTuru";
            this.Txt_kitapTuru.Size = new System.Drawing.Size(69, 30);
            this.Txt_kitapTuru.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(797, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tür";
            // 
            // Txt_raf
            // 
            this.Txt_raf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_raf.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_raf.Location = new System.Drawing.Point(844, 201);
            this.Txt_raf.Name = "Txt_raf";
            this.Txt_raf.Size = new System.Drawing.Size(45, 30);
            this.Txt_raf.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(795, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Raf";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Txt_resim
            // 
            this.Txt_resim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_resim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_resim.Location = new System.Drawing.Point(987, 166);
            this.Txt_resim.Name = "Txt_resim";
            this.Txt_resim.Size = new System.Drawing.Size(85, 30);
            this.Txt_resim.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(925, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Resim";
            // 
            // Txt_satinAlmaFiyati
            // 
            this.Txt_satinAlmaFiyati.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_satinAlmaFiyati.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_satinAlmaFiyati.Location = new System.Drawing.Point(987, 238);
            this.Txt_satinAlmaFiyati.Name = "Txt_satinAlmaFiyati";
            this.Txt_satinAlmaFiyati.Size = new System.Drawing.Size(85, 30);
            this.Txt_satinAlmaFiyati.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(843, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Satın Alma Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(381, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tür";
            // 
            // kitapTuruAra
            // 
            this.kitapTuruAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kitapTuruAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapTuruAra.FormattingEnabled = true;
            this.kitapTuruAra.Items.AddRange(new object[] {
            "",
            "Bilim ve Teknik",
            "Din",
            "Edebiyat",
            "Çocuk Kitapları",
            "Felsefe & Düşünce",
            "Hukuk",
            "Ekonomi & İş Dünyası",
            "Tarih"});
            this.kitapTuruAra.Location = new System.Drawing.Point(421, 56);
            this.kitapTuruAra.Name = "kitapTuruAra";
            this.kitapTuruAra.Size = new System.Drawing.Size(121, 31);
            this.kitapTuruAra.TabIndex = 2;
            this.kitapTuruAra.SelectedIndexChanged += new System.EventHandler(this.KitapTuru_Txt_SelectedIndexChanged);
            // 
            // Txt_id
            // 
            this.Txt_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_id.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_id.Location = new System.Drawing.Point(693, 58);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.ReadOnly = true;
            this.Txt_id.Size = new System.Drawing.Size(45, 30);
            this.Txt_id.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(560, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Kitap Numarası";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resim_btn
            // 
            this.resim_btn.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.icons8_more_16;
            this.resim_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resim_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resim_btn.Location = new System.Drawing.Point(1078, 173);
            this.resim_btn.Name = "resim_btn";
            this.resim_btn.Size = new System.Drawing.Size(24, 23);
            this.resim_btn.TabIndex = 8;
            this.resim_btn.UseVisualStyleBackColor = true;
            this.resim_btn.Click += new System.EventHandler(this.resim_btn_Click);
            // 
            // kitapResmi
            // 
            this.kitapResmi.Location = new System.Drawing.Point(1119, 60);
            this.kitapResmi.Name = "kitapResmi";
            this.kitapResmi.Size = new System.Drawing.Size(174, 202);
            this.kitapResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kitapResmi.TabIndex = 20;
            this.kitapResmi.TabStop = false;
            // 
            // geri_btn
            // 
            this.geri_btn.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.geri_32;
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri_btn.Location = new System.Drawing.Point(12, 12);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(36, 31);
            this.geri_btn.TabIndex = 37;
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // kitaplar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.hareketler;
            this.ClientSize = new System.Drawing.Size(1364, 544);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_satinAlmaFiyati);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kitapTuruAra);
            this.Controls.Add(this.resim_btn);
            this.Controls.Add(this.Txt_resim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_raf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_kitapTuru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kitapListesi);
            this.Controls.Add(this.kitapResmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aramaCubugu);
            this.Controls.Add(this.bilgiGüncelle);
            this.Controls.Add(this.Txt_ozet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_yazarAdi);
            this.Controls.Add(this.Txt_yayinevi);
            this.Controls.Add(this.Txt_fiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_kitapAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitapSat);
            this.Controls.Add(this.kitapSil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kitapSil;
        private System.Windows.Forms.Button kitapSat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_kitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_fiyat;
        private System.Windows.Forms.TextBox Txt_yayinevi;
        private System.Windows.Forms.TextBox Txt_yazarAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_ozet;
        private System.Windows.Forms.Button bilgiGüncelle;
        private System.Windows.Forms.TextBox aramaCubugu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox kitapResmi;
        private SahafOtomasyonuDataSet sahafOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private SahafOtomasyonuDataSetTableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridView kitapListesi;
        private System.Windows.Forms.TextBox Txt_kitapTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_raf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_resim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button resim_btn;
        private System.Windows.Forms.TextBox Txt_satinAlmaFiyati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox kitapTuruAra;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satmaFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn satinAlmaFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn resim;
        private System.Windows.Forms.DataGridViewTextBoxColumn özet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource1;
        private System.Windows.Forms.Button geri_btn;
    }
}