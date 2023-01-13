namespace TenhadaSahafOtomasyon
{
    partial class aylikCiro
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
            this.hesapla_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kira_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gider_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciro_txt = new System.Windows.Forms.TextBox();
            this.aylikKayıtTablosu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylikGelirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet3 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet3();
            this.aylikCiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet1 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet1();
            this.aylikCiroTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet1TableAdapters.aylikCiroTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.sahafOtomasyonuDataSet2 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet2();
            this.sahafOtomasyonuDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aylikGelirTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet3TableAdapters.aylikGelirTableAdapter();
            this.tarih_txt = new System.Windows.Forms.TextBox();
            this.ayBul_txt = new System.Windows.Forms.ComboBox();
            this.geri_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aylikKayıtTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikGelirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikCiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hesapla_btn
            // 
            this.hesapla_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla_btn.Location = new System.Drawing.Point(173, 257);
            this.hesapla_btn.Name = "hesapla_btn";
            this.hesapla_btn.Size = new System.Drawing.Size(75, 31);
            this.hesapla_btn.TabIndex = 3;
            this.hesapla_btn.Text = "Hesapla";
            this.hesapla_btn.UseVisualStyleBackColor = true;
            this.hesapla_btn.Click += new System.EventHandler(this.hesapla_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dükkan Kirası";
            // 
            // kira_txt
            // 
            this.kira_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kira_txt.Location = new System.Drawing.Point(229, 130);
            this.kira_txt.Name = "kira_txt";
            this.kira_txt.Size = new System.Drawing.Size(93, 30);
            this.kira_txt.TabIndex = 1;
            this.kira_txt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Fatura Giderleri";
            // 
            // gider_txt
            // 
            this.gider_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gider_txt.Location = new System.Drawing.Point(229, 176);
            this.gider_txt.Name = "gider_txt";
            this.gider_txt.Size = new System.Drawing.Size(93, 30);
            this.gider_txt.TabIndex = 2;
            this.gider_txt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(117, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aylık Ciro";
            // 
            // ciro_txt
            // 
            this.ciro_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ciro_txt.Location = new System.Drawing.Point(229, 339);
            this.ciro_txt.Name = "ciro_txt";
            this.ciro_txt.ReadOnly = true;
            this.ciro_txt.Size = new System.Drawing.Size(93, 30);
            this.ciro_txt.TabIndex = 8;
            // 
            // aylikKayıtTablosu
            // 
            this.aylikKayıtTablosu.AutoGenerateColumns = false;
            this.aylikKayıtTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aylikKayıtTablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bakiyeDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.aylikKayıtTablosu.DataSource = this.aylikGelirBindingSource;
            this.aylikKayıtTablosu.Location = new System.Drawing.Point(364, 88);
            this.aylikKayıtTablosu.Name = "aylikKayıtTablosu";
            this.aylikKayıtTablosu.RowHeadersVisible = false;
            this.aylikKayıtTablosu.RowHeadersWidth = 51;
            this.aylikKayıtTablosu.RowTemplate.Height = 24;
            this.aylikKayıtTablosu.Size = new System.Drawing.Size(352, 350);
            this.aylikKayıtTablosu.TabIndex = 9;
            this.aylikKayıtTablosu.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // bakiyeDataGridViewTextBoxColumn
            // 
            this.bakiyeDataGridViewTextBoxColumn.DataPropertyName = "bakiye";
            this.bakiyeDataGridViewTextBoxColumn.HeaderText = "bakiye";
            this.bakiyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bakiyeDataGridViewTextBoxColumn.Name = "bakiyeDataGridViewTextBoxColumn";
            this.bakiyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // aylikGelirBindingSource
            // 
            this.aylikGelirBindingSource.DataMember = "aylikGelir";
            this.aylikGelirBindingSource.DataSource = this.sahafOtomasyonuDataSet3;
            // 
            // sahafOtomasyonuDataSet3
            // 
            this.sahafOtomasyonuDataSet3.DataSetName = "SahafOtomasyonuDataSet3";
            this.sahafOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aylikCiroBindingSource
            // 
            this.aylikCiroBindingSource.DataMember = "aylikCiro";
            this.aylikCiroBindingSource.DataSource = this.sahafOtomasyonuDataSet1;
            // 
            // sahafOtomasyonuDataSet1
            // 
            this.sahafOtomasyonuDataSet1.DataSetName = "SahafOtomasyonuDataSet1";
            this.sahafOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aylikCiroTableAdapter
            // 
            this.aylikCiroTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hesaplanılacak Ay";
            // 
            // sahafOtomasyonuDataSet2
            // 
            this.sahafOtomasyonuDataSet2.DataSetName = "SahafOtomasyonuDataSet2";
            this.sahafOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahafOtomasyonuDataSet2BindingSource
            // 
            this.sahafOtomasyonuDataSet2BindingSource.DataSource = this.sahafOtomasyonuDataSet2;
            this.sahafOtomasyonuDataSet2BindingSource.Position = 0;
            // 
            // aylikGelirTableAdapter
            // 
            this.aylikGelirTableAdapter.ClearBeforeFill = true;
            // 
            // tarih_txt
            // 
            this.tarih_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_txt.Location = new System.Drawing.Point(229, 88);
            this.tarih_txt.Name = "tarih_txt";
            this.tarih_txt.Size = new System.Drawing.Size(93, 30);
            this.tarih_txt.TabIndex = 0;
            // 
            // ayBul_txt
            // 
            this.ayBul_txt.FormattingEnabled = true;
            this.ayBul_txt.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.ayBul_txt.Location = new System.Drawing.Point(595, 58);
            this.ayBul_txt.Name = "ayBul_txt";
            this.ayBul_txt.Size = new System.Drawing.Size(121, 24);
            this.ayBul_txt.TabIndex = 12;
            this.ayBul_txt.SelectedIndexChanged += new System.EventHandler(this.ayBul_txt_SelectedIndexChanged);
            // 
            // geri_btn
            // 
            this.geri_btn.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.geri_32;
            this.geri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geri_btn.Location = new System.Drawing.Point(12, 12);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(36, 31);
            this.geri_btn.TabIndex = 38;
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // aylikCiro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.kitaplar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 476);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.ayBul_txt);
            this.Controls.Add(this.tarih_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aylikKayıtTablosu);
            this.Controls.Add(this.ciro_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gider_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kira_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapla_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aylikCiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aylikCiro";
            this.Load += new System.EventHandler(this.aylikCiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aylikKayıtTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikGelirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikCiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kira_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gider_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ciro_txt;
        private System.Windows.Forms.DataGridView aylikKayıtTablosu;
        private SahafOtomasyonuDataSet1 sahafOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource aylikCiroBindingSource;
        private SahafOtomasyonuDataSet1TableAdapters.aylikCiroTableAdapter aylikCiroTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sahafOtomasyonuDataSet2BindingSource;
        private SahafOtomasyonuDataSet2 sahafOtomasyonuDataSet2;
        private SahafOtomasyonuDataSet3 sahafOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource aylikGelirBindingSource;
        private SahafOtomasyonuDataSet3TableAdapters.aylikGelirTableAdapter aylikGelirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tarih_txt;
        private System.Windows.Forms.ComboBox ayBul_txt;
        private System.Windows.Forms.Button geri_btn;
    }
}