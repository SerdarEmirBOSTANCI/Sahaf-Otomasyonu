namespace TenhadaSahafOtomasyon
{
    partial class gunlukHareketler
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
            this.gunuBitir = new System.Windows.Forms.Button();
            this.bakiye_txt = new System.Windows.Forms.TextBox();
            this.gunlukHareketListesi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunlukHareketlerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunlukHareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahafOtomasyonuDataSet1 = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet1();
            this.sahafOtomasyonuDataSet = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet();
            this.sahafOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunlukHareketlerTableAdapter = new TenhadaSahafOtomasyon.SahafOtomasyonuDataSet1TableAdapters.gunlukHareketlerTableAdapter();
            this.bakiyeGoster = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukHareketListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukHareketlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunuBitir
            // 
            this.gunuBitir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunuBitir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunuBitir.Location = new System.Drawing.Point(22, 71);
            this.gunuBitir.Name = "gunuBitir";
            this.gunuBitir.Size = new System.Drawing.Size(125, 35);
            this.gunuBitir.TabIndex = 1;
            this.gunuBitir.Text = "Günü Bitir";
            this.gunuBitir.UseVisualStyleBackColor = true;
            this.gunuBitir.Click += new System.EventHandler(this.gunuBitir_Click);
            // 
            // bakiye_txt
            // 
            this.bakiye_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bakiye_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiye_txt.Location = new System.Drawing.Point(636, 73);
            this.bakiye_txt.Name = "bakiye_txt";
            this.bakiye_txt.ReadOnly = true;
            this.bakiye_txt.Size = new System.Drawing.Size(95, 30);
            this.bakiye_txt.TabIndex = 6;
            // 
            // gunlukHareketListesi
            // 
            this.gunlukHareketListesi.AutoGenerateColumns = false;
            this.gunlukHareketListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunlukHareketListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.gunlukHareketlerDataGridViewTextBoxColumn});
            this.gunlukHareketListesi.DataSource = this.gunlukHareketlerBindingSource;
            this.gunlukHareketListesi.Location = new System.Drawing.Point(22, 123);
            this.gunlukHareketListesi.Name = "gunlukHareketListesi";
            this.gunlukHareketListesi.RowHeadersVisible = false;
            this.gunlukHareketListesi.RowHeadersWidth = 51;
            this.gunlukHareketListesi.RowTemplate.Height = 24;
            this.gunlukHareketListesi.Size = new System.Drawing.Size(721, 315);
            this.gunlukHareketListesi.TabIndex = 7;
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
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // gunlukHareketlerDataGridViewTextBoxColumn
            // 
            this.gunlukHareketlerDataGridViewTextBoxColumn.DataPropertyName = "gunlukHareketler";
            this.gunlukHareketlerDataGridViewTextBoxColumn.HeaderText = "Günlük Hareketler";
            this.gunlukHareketlerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gunlukHareketlerDataGridViewTextBoxColumn.Name = "gunlukHareketlerDataGridViewTextBoxColumn";
            this.gunlukHareketlerDataGridViewTextBoxColumn.Width = 557;
            // 
            // gunlukHareketlerBindingSource
            // 
            this.gunlukHareketlerBindingSource.DataMember = "gunlukHareketler";
            this.gunlukHareketlerBindingSource.DataSource = this.sahafOtomasyonuDataSet1;
            // 
            // sahafOtomasyonuDataSet1
            // 
            this.sahafOtomasyonuDataSet1.DataSetName = "SahafOtomasyonuDataSet1";
            this.sahafOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahafOtomasyonuDataSet
            // 
            this.sahafOtomasyonuDataSet.DataSetName = "SahafOtomasyonuDataSet";
            this.sahafOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahafOtomasyonuDataSetBindingSource
            // 
            this.sahafOtomasyonuDataSetBindingSource.DataSource = this.sahafOtomasyonuDataSet;
            this.sahafOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // gunlukHareketlerTableAdapter
            // 
            this.gunlukHareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // bakiyeGoster
            // 
            this.bakiyeGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bakiyeGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyeGoster.Location = new System.Drawing.Point(418, 71);
            this.bakiyeGoster.Name = "bakiyeGoster";
            this.bakiyeGoster.Size = new System.Drawing.Size(203, 35);
            this.bakiyeGoster.TabIndex = 2;
            this.bakiyeGoster.Text = "Mevcut Kasa Bakiyesi";
            this.bakiyeGoster.UseVisualStyleBackColor = true;
            this.bakiyeGoster.Click += new System.EventHandler(this.bakiyeGoster_Click);
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
            // gunlukHareketler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.kitaplar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 467);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.bakiyeGoster);
            this.Controls.Add(this.gunlukHareketListesi);
            this.Controls.Add(this.bakiye_txt);
            this.Controls.Add(this.gunuBitir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gunlukHareketler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gunlukHareketler";
            this.Load += new System.EventHandler(this.gunlukHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunlukHareketListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukHareketlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahafOtomasyonuDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gunuBitir;
        private System.Windows.Forms.TextBox bakiye_txt;
        private System.Windows.Forms.DataGridView gunlukHareketListesi;
        private System.Windows.Forms.BindingSource sahafOtomasyonuDataSetBindingSource;
        private SahafOtomasyonuDataSet sahafOtomasyonuDataSet;
        private SahafOtomasyonuDataSet1 sahafOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource gunlukHareketlerBindingSource;
        private SahafOtomasyonuDataSet1TableAdapters.gunlukHareketlerTableAdapter gunlukHareketlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunlukHareketlerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bakiyeGoster;
        private System.Windows.Forms.Button geri_btn;
    }
}