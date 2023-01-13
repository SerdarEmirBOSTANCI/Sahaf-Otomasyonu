namespace TenhadaSahafOtomasyon
{
    partial class GirisYap
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
            this.kayitOl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.kullanici_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kayitOl
            // 
            this.kayitOl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayitOl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOl.Location = new System.Drawing.Point(253, 288);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(100, 34);
            this.kayitOl.TabIndex = 4;
            this.kayitOl.Text = "Kayıt Ol";
            this.kayitOl.UseVisualStyleBackColor = true;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(117, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifre_txt
            // 
            this.sifre_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sifre_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_txt.Location = new System.Drawing.Point(194, 207);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(206, 30);
            this.sifre_txt.TabIndex = 1;
            // 
            // kullanici_txt
            // 
            this.kullanici_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullanici_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.kullanici_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_txt.Location = new System.Drawing.Point(194, 131);
            this.kullanici_txt.Name = "kullanici_txt";
            this.kullanici_txt.Size = new System.Drawing.Size(206, 30);
            this.kullanici_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre             ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.çıkışButonu_32;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.Location = new System.Drawing.Point(448, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 31);
            this.exit.TabIndex = 7;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::TenhadaSahafOtomasyon.Properties.Resources.arkaPlan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 452);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kullanici_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisYap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitOl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.TextBox kullanici_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
    }
}

