namespace KAFE
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siparisGroupBox = new System.Windows.Forms.GroupBox();
            this.kolaEksiButton = new System.Windows.Forms.Button();
            this.kolaArtiButton = new System.Windows.Forms.Button();
            this.kolaSayisiLabel = new System.Windows.Forms.Label();
            this.kolaLabel = new System.Windows.Forms.Label();
            this.kahveEksiButton = new System.Windows.Forms.Button();
            this.kahveArtiButton = new System.Windows.Forms.Button();
            this.kahveSayisiLabel = new System.Windows.Forms.Label();
            this.kahveLabel = new System.Windows.Forms.Label();
            this.cayEksiButton = new System.Windows.Forms.Button();
            this.cayArtiButton = new System.Windows.Forms.Button();
            this.caySayisiLabel = new System.Windows.Forms.Label();
            this.cayLabel = new System.Windows.Forms.Label();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.siparisiTamamlaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.limonataEksiButton = new System.Windows.Forms.Button();
            this.limonataArtiButton = new System.Windows.Forms.Button();
            this.limonataSayisiLabel = new System.Windows.Forms.Label();
            this.limonataLabel = new System.Windows.Forms.Label();
            this.siparisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparisGroupBox
            // 
            this.siparisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisGroupBox.Controls.Add(this.limonataEksiButton);
            this.siparisGroupBox.Controls.Add(this.limonataArtiButton);
            this.siparisGroupBox.Controls.Add(this.limonataSayisiLabel);
            this.siparisGroupBox.Controls.Add(this.limonataLabel);
            this.siparisGroupBox.Controls.Add(this.kolaEksiButton);
            this.siparisGroupBox.Controls.Add(this.kolaArtiButton);
            this.siparisGroupBox.Controls.Add(this.kolaSayisiLabel);
            this.siparisGroupBox.Controls.Add(this.kolaLabel);
            this.siparisGroupBox.Controls.Add(this.kahveEksiButton);
            this.siparisGroupBox.Controls.Add(this.kahveArtiButton);
            this.siparisGroupBox.Controls.Add(this.kahveSayisiLabel);
            this.siparisGroupBox.Controls.Add(this.kahveLabel);
            this.siparisGroupBox.Controls.Add(this.cayEksiButton);
            this.siparisGroupBox.Controls.Add(this.cayArtiButton);
            this.siparisGroupBox.Controls.Add(this.caySayisiLabel);
            this.siparisGroupBox.Controls.Add(this.cayLabel);
            this.siparisGroupBox.Location = new System.Drawing.Point(86, 101);
            this.siparisGroupBox.Name = "siparisGroupBox";
            this.siparisGroupBox.Size = new System.Drawing.Size(584, 368);
            this.siparisGroupBox.TabIndex = 0;
            this.siparisGroupBox.TabStop = false;
            this.siparisGroupBox.Text = "SİPARİŞ";
            this.siparisGroupBox.Enter += new System.EventHandler(this.siparisGroupBox_Enter);
            // 
            // kolaEksiButton
            // 
            this.kolaEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaEksiButton.Location = new System.Drawing.Point(411, 212);
            this.kolaEksiButton.Name = "kolaEksiButton";
            this.kolaEksiButton.Size = new System.Drawing.Size(39, 38);
            this.kolaEksiButton.TabIndex = 12;
            this.kolaEksiButton.Text = "-";
            this.kolaEksiButton.UseVisualStyleBackColor = true;
            this.kolaEksiButton.Click += new System.EventHandler(this.kolaEksiButton_Click);
            // 
            // kolaArtiButton
            // 
            this.kolaArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaArtiButton.Location = new System.Drawing.Point(335, 212);
            this.kolaArtiButton.Name = "kolaArtiButton";
            this.kolaArtiButton.Size = new System.Drawing.Size(41, 38);
            this.kolaArtiButton.TabIndex = 11;
            this.kolaArtiButton.Text = "+";
            this.kolaArtiButton.UseVisualStyleBackColor = true;
            this.kolaArtiButton.Click += new System.EventHandler(this.kolaArtiButton_Click);
            // 
            // kolaSayisiLabel
            // 
            this.kolaSayisiLabel.AutoSize = true;
            this.kolaSayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaSayisiLabel.Location = new System.Drawing.Point(234, 220);
            this.kolaSayisiLabel.Name = "kolaSayisiLabel";
            this.kolaSayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.kolaSayisiLabel.TabIndex = 10;
            this.kolaSayisiLabel.Text = "0";
            // 
            // kolaLabel
            // 
            this.kolaLabel.AutoSize = true;
            this.kolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaLabel.Location = new System.Drawing.Point(102, 220);
            this.kolaLabel.Name = "kolaLabel";
            this.kolaLabel.Size = new System.Drawing.Size(54, 20);
            this.kolaLabel.TabIndex = 9;
            this.kolaLabel.Text = "KOLA";
            // 
            // kahveEksiButton
            // 
            this.kahveEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveEksiButton.Location = new System.Drawing.Point(411, 140);
            this.kahveEksiButton.Name = "kahveEksiButton";
            this.kahveEksiButton.Size = new System.Drawing.Size(39, 38);
            this.kahveEksiButton.TabIndex = 8;
            this.kahveEksiButton.Text = "-";
            this.kahveEksiButton.UseVisualStyleBackColor = true;
            this.kahveEksiButton.Click += new System.EventHandler(this.kahveEksiButton_Click);
            // 
            // kahveArtiButton
            // 
            this.kahveArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveArtiButton.Location = new System.Drawing.Point(335, 140);
            this.kahveArtiButton.Name = "kahveArtiButton";
            this.kahveArtiButton.Size = new System.Drawing.Size(41, 38);
            this.kahveArtiButton.TabIndex = 7;
            this.kahveArtiButton.Text = "+";
            this.kahveArtiButton.UseVisualStyleBackColor = true;
            this.kahveArtiButton.Click += new System.EventHandler(this.kahveArtiButton_Click);
            // 
            // kahveSayisiLabel
            // 
            this.kahveSayisiLabel.AutoSize = true;
            this.kahveSayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveSayisiLabel.Location = new System.Drawing.Point(234, 148);
            this.kahveSayisiLabel.Name = "kahveSayisiLabel";
            this.kahveSayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.kahveSayisiLabel.TabIndex = 6;
            this.kahveSayisiLabel.Text = "0";
            // 
            // kahveLabel
            // 
            this.kahveLabel.AutoSize = true;
            this.kahveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveLabel.Location = new System.Drawing.Point(90, 148);
            this.kahveLabel.Name = "kahveLabel";
            this.kahveLabel.Size = new System.Drawing.Size(66, 20);
            this.kahveLabel.TabIndex = 5;
            this.kahveLabel.Text = "KAHVE";
            // 
            // cayEksiButton
            // 
            this.cayEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayEksiButton.Location = new System.Drawing.Point(411, 66);
            this.cayEksiButton.Name = "cayEksiButton";
            this.cayEksiButton.Size = new System.Drawing.Size(39, 38);
            this.cayEksiButton.TabIndex = 4;
            this.cayEksiButton.Text = "-";
            this.cayEksiButton.UseVisualStyleBackColor = true;
            this.cayEksiButton.Click += new System.EventHandler(this.cayEksiButton_Click);
            // 
            // cayArtiButton
            // 
            this.cayArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayArtiButton.Location = new System.Drawing.Point(335, 66);
            this.cayArtiButton.Name = "cayArtiButton";
            this.cayArtiButton.Size = new System.Drawing.Size(41, 38);
            this.cayArtiButton.TabIndex = 3;
            this.cayArtiButton.Text = "+";
            this.cayArtiButton.UseVisualStyleBackColor = true;
            this.cayArtiButton.Click += new System.EventHandler(this.cayArtiButton_Click);
            // 
            // caySayisiLabel
            // 
            this.caySayisiLabel.AutoSize = true;
            this.caySayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.caySayisiLabel.Location = new System.Drawing.Point(234, 74);
            this.caySayisiLabel.Name = "caySayisiLabel";
            this.caySayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.caySayisiLabel.TabIndex = 2;
            this.caySayisiLabel.Text = "0";
            // 
            // cayLabel
            // 
            this.cayLabel.AutoSize = true;
            this.cayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayLabel.Location = new System.Drawing.Point(114, 74);
            this.cayLabel.Name = "cayLabel";
            this.cayLabel.Size = new System.Drawing.Size(42, 20);
            this.cayLabel.TabIndex = 1;
            this.cayLabel.Text = "ÇAY";
            this.cayLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sifirlaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirlaButton.Location = new System.Drawing.Point(248, 488);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(171, 34);
            this.sifirlaButton.TabIndex = 1;
            this.sifirlaButton.Text = "SIFIRLA";
            this.sifirlaButton.UseVisualStyleBackColor = true;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);
            // 
            // siparisiTamamlaButton
            // 
            this.siparisiTamamlaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisiTamamlaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisiTamamlaButton.Location = new System.Drawing.Point(425, 488);
            this.siparisiTamamlaButton.Name = "siparisiTamamlaButton";
            this.siparisiTamamlaButton.Size = new System.Drawing.Size(245, 34);
            this.siparisiTamamlaButton.TabIndex = 2;
            this.siparisiTamamlaButton.Text = "SİPARİŞİ TAMAMLA";
            this.siparisiTamamlaButton.UseVisualStyleBackColor = true;
            this.siparisiTamamlaButton.Click += new System.EventHandler(this.siparisiTamamlaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOŞGELDİNİZ..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(117, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duman Kafe";
            // 
            // cikisButton
            // 
            this.cikisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(85, 488);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(157, 34);
            this.cikisButton.TabIndex = 5;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // limonataEksiButton
            // 
            this.limonataEksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.limonataEksiButton.Location = new System.Drawing.Point(411, 278);
            this.limonataEksiButton.Name = "limonataEksiButton";
            this.limonataEksiButton.Size = new System.Drawing.Size(39, 38);
            this.limonataEksiButton.TabIndex = 16;
            this.limonataEksiButton.Text = "-";
            this.limonataEksiButton.UseVisualStyleBackColor = true;
            this.limonataEksiButton.Click += new System.EventHandler(this.limonataEksiButton_Click);
            // 
            // limonataArtiButton
            // 
            this.limonataArtiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.limonataArtiButton.Location = new System.Drawing.Point(335, 278);
            this.limonataArtiButton.Name = "limonataArtiButton";
            this.limonataArtiButton.Size = new System.Drawing.Size(41, 38);
            this.limonataArtiButton.TabIndex = 15;
            this.limonataArtiButton.Text = "+";
            this.limonataArtiButton.UseVisualStyleBackColor = true;
            this.limonataArtiButton.Click += new System.EventHandler(this.limonataArtiButton_Click);
            // 
            // limonataSayisiLabel
            // 
            this.limonataSayisiLabel.AutoSize = true;
            this.limonataSayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.limonataSayisiLabel.Location = new System.Drawing.Point(234, 286);
            this.limonataSayisiLabel.Name = "limonataSayisiLabel";
            this.limonataSayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.limonataSayisiLabel.TabIndex = 14;
            this.limonataSayisiLabel.Text = "0";
            // 
            // limonataLabel
            // 
            this.limonataLabel.AutoSize = true;
            this.limonataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.limonataLabel.Location = new System.Drawing.Point(62, 286);
            this.limonataLabel.Name = "limonataLabel";
            this.limonataLabel.Size = new System.Drawing.Size(94, 20);
            this.limonataLabel.TabIndex = 13;
            this.limonataLabel.Text = "LİMONATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(711, 571);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siparisiTamamlaButton);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.siparisGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(729, 547);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAFE SİPARİŞ EKRANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siparisGroupBox.ResumeLayout(false);
            this.siparisGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox siparisGroupBox;
        private System.Windows.Forms.Label cayLabel;
        private System.Windows.Forms.Button kolaEksiButton;
        private System.Windows.Forms.Button kolaArtiButton;
        private System.Windows.Forms.Label kolaSayisiLabel;
        private System.Windows.Forms.Label kolaLabel;
        private System.Windows.Forms.Button kahveEksiButton;
        private System.Windows.Forms.Button kahveArtiButton;
        private System.Windows.Forms.Label kahveSayisiLabel;
        private System.Windows.Forms.Label kahveLabel;
        private System.Windows.Forms.Button cayEksiButton;
        private System.Windows.Forms.Button cayArtiButton;
        private System.Windows.Forms.Label caySayisiLabel;
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Button siparisiTamamlaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button limonataEksiButton;
        private System.Windows.Forms.Button limonataArtiButton;
        private System.Windows.Forms.Label limonataSayisiLabel;
        private System.Windows.Forms.Label limonataLabel;
    }
}

