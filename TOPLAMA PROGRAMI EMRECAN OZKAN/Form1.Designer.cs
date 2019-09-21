namespace TOPLAMA_PROGRAMI_EMRECAN_OZKAN
{
    partial class FormToplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToplama));
            this.tabGenel = new System.Windows.Forms.TabControl();
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.buttonİleri = new System.Windows.Forms.Button();
            this.textBoxSonuç = new System.Windows.Forms.TextBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.textBoxİkinciSayı = new System.Windows.Forms.TextBox();
            this.textBoxBirinciSayı = new System.Windows.Forms.TextBox();
            this.labelİkinciSayı = new System.Windows.Forms.Label();
            this.labelBirinciSayi = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.tabLoglama = new System.Windows.Forms.TabPage();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.listViewLoglama = new System.Windows.Forms.ListView();
            this.buttonSecileniSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabGenel.SuspendLayout();
            this.tabToplama.SuspendLayout();
            this.tabLoglama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.tabToplama);
            this.tabGenel.Controls.Add(this.tabLoglama);
            this.tabGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGenel.Location = new System.Drawing.Point(0, 0);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.SelectedIndex = 0;
            this.tabGenel.Size = new System.Drawing.Size(570, 408);
            this.tabGenel.TabIndex = 0;
            // 
            // tabToplama
            // 
            this.tabToplama.Controls.Add(this.pictureBox1);
            this.tabToplama.Controls.Add(this.buttonİleri);
            this.tabToplama.Controls.Add(this.textBoxSonuç);
            this.tabToplama.Controls.Add(this.labelSonuc);
            this.tabToplama.Controls.Add(this.textBoxİkinciSayı);
            this.tabToplama.Controls.Add(this.textBoxBirinciSayı);
            this.tabToplama.Controls.Add(this.labelİkinciSayı);
            this.tabToplama.Controls.Add(this.labelBirinciSayi);
            this.tabToplama.Controls.Add(this.btnTopla);
            this.tabToplama.Location = new System.Drawing.Point(4, 25);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(3);
            this.tabToplama.Size = new System.Drawing.Size(562, 379);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            this.tabToplama.UseVisualStyleBackColor = true;
            // 
            // buttonİleri
            // 
            this.buttonİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonİleri.Location = new System.Drawing.Point(129, 301);
            this.buttonİleri.Name = "buttonİleri";
            this.buttonİleri.Size = new System.Drawing.Size(290, 34);
            this.buttonİleri.TabIndex = 23;
            this.buttonİleri.Text = "İleri";
            this.buttonİleri.UseVisualStyleBackColor = true;
            this.buttonİleri.Click += new System.EventHandler(this.Buttonİleri_Click);
            // 
            // textBoxSonuç
            // 
            this.textBoxSonuç.Enabled = false;
            this.textBoxSonuç.Location = new System.Drawing.Point(235, 257);
            this.textBoxSonuç.Name = "textBoxSonuç";
            this.textBoxSonuç.Size = new System.Drawing.Size(184, 22);
            this.textBoxSonuç.TabIndex = 22;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(126, 262);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(48, 17);
            this.labelSonuc.TabIndex = 21;
            this.labelSonuc.Text = "Sonuç";
            // 
            // textBoxİkinciSayı
            // 
            this.textBoxİkinciSayı.Location = new System.Drawing.Point(235, 162);
            this.textBoxİkinciSayı.Name = "textBoxİkinciSayı";
            this.textBoxİkinciSayı.Size = new System.Drawing.Size(184, 22);
            this.textBoxİkinciSayı.TabIndex = 18;
            this.textBoxİkinciSayı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxİkinciSayı_KeyPress);
            // 
            // textBoxBirinciSayı
            // 
            this.textBoxBirinciSayı.Location = new System.Drawing.Point(235, 126);
            this.textBoxBirinciSayı.Name = "textBoxBirinciSayı";
            this.textBoxBirinciSayı.Size = new System.Drawing.Size(184, 22);
            this.textBoxBirinciSayı.TabIndex = 16;
            this.textBoxBirinciSayı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBirinciSayı_KeyPress);
            // 
            // labelİkinciSayı
            // 
            this.labelİkinciSayı.AutoSize = true;
            this.labelİkinciSayı.Location = new System.Drawing.Point(126, 162);
            this.labelİkinciSayı.Name = "labelİkinciSayı";
            this.labelİkinciSayı.Size = new System.Drawing.Size(70, 17);
            this.labelİkinciSayı.TabIndex = 19;
            this.labelİkinciSayı.Text = "İkinci Sayı";
            // 
            // labelBirinciSayi
            // 
            this.labelBirinciSayi.AutoSize = true;
            this.labelBirinciSayi.Location = new System.Drawing.Point(126, 126);
            this.labelBirinciSayi.Name = "labelBirinciSayi";
            this.labelBirinciSayi.Size = new System.Drawing.Size(77, 17);
            this.labelBirinciSayi.TabIndex = 17;
            this.labelBirinciSayi.Text = "Birinci Sayı";
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(129, 199);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(290, 33);
            this.btnTopla.TabIndex = 20;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // tabLoglama
            // 
            this.tabLoglama.Controls.Add(this.buttonSecileniSil);
            this.tabLoglama.Controls.Add(this.listViewLoglama);
            this.tabLoglama.Controls.Add(this.buttonTemizle);
            this.tabLoglama.Controls.Add(this.buttonGeri);
            this.tabLoglama.Location = new System.Drawing.Point(4, 25);
            this.tabLoglama.Name = "tabLoglama";
            this.tabLoglama.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoglama.Size = new System.Drawing.Size(562, 379);
            this.tabLoglama.TabIndex = 1;
            this.tabLoglama.Text = "Loglama";
            this.tabLoglama.UseVisualStyleBackColor = true;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.Location = new System.Drawing.Point(43, 316);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(107, 52);
            this.buttonGeri.TabIndex = 1;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.ButtonGeri_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Location = new System.Drawing.Point(414, 316);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(116, 52);
            this.buttonTemizle.TabIndex = 3;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.ButtonTemizle_Click);
            // 
            // listViewLoglama
            // 
            this.listViewLoglama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewLoglama.HideSelection = false;
            this.listViewLoglama.Location = new System.Drawing.Point(6, 3);
            this.listViewLoglama.Name = "listViewLoglama";
            this.listViewLoglama.Size = new System.Drawing.Size(548, 285);
            this.listViewLoglama.TabIndex = 0;
            this.listViewLoglama.UseCompatibleStateImageBehavior = false;
            this.listViewLoglama.View = System.Windows.Forms.View.List;
            // 
            // buttonSecileniSil
            // 
            this.buttonSecileniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSecileniSil.Location = new System.Drawing.Point(210, 319);
            this.buttonSecileniSil.Name = "buttonSecileniSil";
            this.buttonSecileniSil.Size = new System.Drawing.Size(151, 52);
            this.buttonSecileniSil.TabIndex = 2;
            this.buttonSecileniSil.Text = "Seçileni Sil";
            this.buttonSecileniSil.UseVisualStyleBackColor = true;
            this.buttonSecileniSil.Click += new System.EventHandler(this.ButtonSecileniSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TOPLAMA_PROGRAMI_EMRECAN_OZKAN.Properties.Resources.logo_toplama_programı;
            this.pictureBox1.Location = new System.Drawing.Point(129, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FormToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 408);
            this.Controls.Add(this.tabGenel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormToplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama Programı | EMRECAN ÖZKAN";
            this.Shown += new System.EventHandler(this.FormToplama_Shown);
            this.tabGenel.ResumeLayout(false);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tabLoglama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGenel;
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.Button buttonİleri;
        private System.Windows.Forms.TextBox textBoxSonuç;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.TextBox textBoxİkinciSayı;
        private System.Windows.Forms.TextBox textBoxBirinciSayı;
        private System.Windows.Forms.Label labelİkinciSayı;
        private System.Windows.Forms.Label labelBirinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TabPage tabLoglama;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.ListView listViewLoglama;
        private System.Windows.Forms.Button buttonSecileniSil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

