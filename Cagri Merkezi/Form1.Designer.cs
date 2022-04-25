
namespace Cagri_Merkezi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGenel = new System.Windows.Forms.TabControl();
            this.tbMusteriArama = new System.Windows.Forms.TabPage();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.rdoBireysel = new System.Windows.Forms.RadioButton();
            this.rdoTicari = new System.Windows.Forms.RadioButton();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.tbAramaCevap = new System.Windows.Forms.TabPage();
            this.tbTemsilciler = new System.Windows.Forms.TabControl();
            this.tbTemsilci1 = new System.Windows.Forms.TabPage();
            this.lblNot1 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.Temsilci_Durum = new System.Windows.Forms.ListBox();
            this.btnCagriSonlandir1 = new System.Windows.Forms.Button();
            this.tbTemsilci2 = new System.Windows.Forms.TabPage();
            this.lnlNot2 = new System.Windows.Forms.Label();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.Temsilci_Durum2 = new System.Windows.Forms.ListBox();
            this.btnCagriSonlandir2 = new System.Windows.Forms.Button();
            this.tbTemsilci3 = new System.Windows.Forms.TabPage();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.lblNot3 = new System.Windows.Forms.Label();
            this.Temsilci_Durum3 = new System.Windows.Forms.ListBox();
            this.btnCagriSonlandir3 = new System.Windows.Forms.Button();
            this.tbTemsilci4 = new System.Windows.Forms.TabPage();
            this.lblNot4 = new System.Windows.Forms.Label();
            this.txtNot4 = new System.Windows.Forms.TextBox();
            this.Temsilci_Durum4 = new System.Windows.Forms.ListBox();
            this.btnCagriSonlandir4 = new System.Windows.Forms.Button();
            this.btnCagriEkle = new System.Windows.Forms.Button();
            this.Bekleyen_Musteriler = new System.Windows.Forms.ListBox();
            this.tbCagri_Kayitlari = new System.Windows.Forms.TabPage();
            this.Kayitlar = new System.Windows.Forms.ListBox();
            this.tbGenel.SuspendLayout();
            this.tbMusteriArama.SuspendLayout();
            this.tbAramaCevap.SuspendLayout();
            this.tbTemsilciler.SuspendLayout();
            this.tbTemsilci1.SuspendLayout();
            this.tbTemsilci2.SuspendLayout();
            this.tbTemsilci3.SuspendLayout();
            this.tbTemsilci4.SuspendLayout();
            this.tbCagri_Kayitlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGenel
            // 
            this.tbGenel.Controls.Add(this.tbMusteriArama);
            this.tbGenel.Controls.Add(this.tbAramaCevap);
            this.tbGenel.Controls.Add(this.tbCagri_Kayitlari);
            this.tbGenel.Location = new System.Drawing.Point(-3, -2);
            this.tbGenel.Name = "tbGenel";
            this.tbGenel.SelectedIndex = 0;
            this.tbGenel.Size = new System.Drawing.Size(1353, 771);
            this.tbGenel.TabIndex = 0;
            // 
            // tbMusteriArama
            // 
            this.tbMusteriArama.Controls.Add(this.dtPicker);
            this.tbMusteriArama.Controls.Add(this.btnSubmit);
            this.tbMusteriArama.Controls.Add(this.lblBaslik);
            this.tbMusteriArama.Controls.Add(this.rdoBireysel);
            this.tbMusteriArama.Controls.Add(this.rdoTicari);
            this.tbMusteriArama.Controls.Add(this.lblTelNo);
            this.tbMusteriArama.Controls.Add(this.txtTelNo);
            this.tbMusteriArama.Controls.Add(this.lblSoyad);
            this.tbMusteriArama.Controls.Add(this.txtSoyad);
            this.tbMusteriArama.Controls.Add(this.lblMusteriAd);
            this.tbMusteriArama.Controls.Add(this.txtMusteriAd);
            this.tbMusteriArama.Location = new System.Drawing.Point(4, 29);
            this.tbMusteriArama.Name = "tbMusteriArama";
            this.tbMusteriArama.Padding = new System.Windows.Forms.Padding(3);
            this.tbMusteriArama.Size = new System.Drawing.Size(1345, 738);
            this.tbMusteriArama.TabIndex = 0;
            this.tbMusteriArama.Text = "Arama";
            this.tbMusteriArama.UseVisualStyleBackColor = true;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(379, 335);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(302, 27);
            this.dtPicker.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(450, 479);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 46);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Arama Baslat";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(474, 94);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(171, 20);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Musteri Bilgilerini Giriniz";
            // 
            // rdoBireysel
            // 
            this.rdoBireysel.AutoSize = true;
            this.rdoBireysel.Location = new System.Drawing.Point(450, 439);
            this.rdoBireysel.Name = "rdoBireysel";
            this.rdoBireysel.Size = new System.Drawing.Size(81, 24);
            this.rdoBireysel.TabIndex = 7;
            this.rdoBireysel.TabStop = true;
            this.rdoBireysel.Text = "Bireysel";
            this.rdoBireysel.UseVisualStyleBackColor = true;
            // 
            // rdoTicari
            // 
            this.rdoTicari.AutoSize = true;
            this.rdoTicari.Location = new System.Drawing.Point(450, 400);
            this.rdoTicari.Name = "rdoTicari";
            this.rdoTicari.Size = new System.Drawing.Size(66, 24);
            this.rdoTicari.TabIndex = 6;
            this.rdoTicari.TabStop = true;
            this.rdoTicari.Text = "Ticari";
            this.rdoTicari.UseVisualStyleBackColor = true;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(379, 274);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(59, 20);
            this.lblTelNo.TabIndex = 5;
            this.lblTelNo.Text = "Tel No :";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(450, 267);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(231, 27);
            this.txtTelNo.TabIndex = 4;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(379, 212);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 20);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(450, 205);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(231, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(379, 149);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(35, 20);
            this.lblMusteriAd.TabIndex = 1;
            this.lblMusteriAd.Text = "Ad :";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(450, 142);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(231, 27);
            this.txtMusteriAd.TabIndex = 0;
            // 
            // tbAramaCevap
            // 
            this.tbAramaCevap.Controls.Add(this.tbTemsilciler);
            this.tbAramaCevap.Controls.Add(this.btnCagriEkle);
            this.tbAramaCevap.Controls.Add(this.Bekleyen_Musteriler);
            this.tbAramaCevap.Location = new System.Drawing.Point(4, 29);
            this.tbAramaCevap.Name = "tbAramaCevap";
            this.tbAramaCevap.Padding = new System.Windows.Forms.Padding(3);
            this.tbAramaCevap.Size = new System.Drawing.Size(1345, 738);
            this.tbAramaCevap.TabIndex = 1;
            this.tbAramaCevap.Text = "Aramayı Cevaplama";
            this.tbAramaCevap.UseVisualStyleBackColor = true;
            // 
            // tbTemsilciler
            // 
            this.tbTemsilciler.Controls.Add(this.tbTemsilci1);
            this.tbTemsilciler.Controls.Add(this.tbTemsilci2);
            this.tbTemsilciler.Controls.Add(this.tbTemsilci3);
            this.tbTemsilciler.Controls.Add(this.tbTemsilci4);
            this.tbTemsilciler.Location = new System.Drawing.Point(230, 297);
            this.tbTemsilciler.Name = "tbTemsilciler";
            this.tbTemsilciler.SelectedIndex = 0;
            this.tbTemsilciler.Size = new System.Drawing.Size(816, 326);
            this.tbTemsilciler.TabIndex = 4;
            // 
            // tbTemsilci1
            // 
            this.tbTemsilci1.Controls.Add(this.lblNot1);
            this.tbTemsilci1.Controls.Add(this.txtNot1);
            this.tbTemsilci1.Controls.Add(this.Temsilci_Durum);
            this.tbTemsilci1.Controls.Add(this.btnCagriSonlandir1);
            this.tbTemsilci1.Location = new System.Drawing.Point(4, 29);
            this.tbTemsilci1.Name = "tbTemsilci1";
            this.tbTemsilci1.Padding = new System.Windows.Forms.Padding(3);
            this.tbTemsilci1.Size = new System.Drawing.Size(808, 293);
            this.tbTemsilci1.TabIndex = 0;
            this.tbTemsilci1.Text = "Temsilci 1";
            this.tbTemsilci1.UseVisualStyleBackColor = true;
            // 
            // lblNot1
            // 
            this.lblNot1.AutoSize = true;
            this.lblNot1.Location = new System.Drawing.Point(26, 225);
            this.lblNot1.Name = "lblNot1";
            this.lblNot1.Size = new System.Drawing.Size(84, 20);
            this.lblNot1.TabIndex = 9;
            this.lblNot1.Text = "Cagri Notu:";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(116, 222);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(125, 27);
            this.txtNot1.TabIndex = 10;
            // 
            // Temsilci_Durum
            // 
            this.Temsilci_Durum.FormattingEnabled = true;
            this.Temsilci_Durum.ItemHeight = 20;
            this.Temsilci_Durum.Location = new System.Drawing.Point(13, 16);
            this.Temsilci_Durum.Name = "Temsilci_Durum";
            this.Temsilci_Durum.Size = new System.Drawing.Size(433, 244);
            this.Temsilci_Durum.TabIndex = 5;
            // 
            // btnCagriSonlandir1
            // 
            this.btnCagriSonlandir1.Location = new System.Drawing.Point(663, 225);
            this.btnCagriSonlandir1.Name = "btnCagriSonlandir1";
            this.btnCagriSonlandir1.Size = new System.Drawing.Size(112, 38);
            this.btnCagriSonlandir1.TabIndex = 4;
            this.btnCagriSonlandir1.Text = "Sonlandır";
            this.btnCagriSonlandir1.UseVisualStyleBackColor = true;
            this.btnCagriSonlandir1.Click += new System.EventHandler(this.btnCagriSonlandir1_Click);
            // 
            // tbTemsilci2
            // 
            this.tbTemsilci2.Controls.Add(this.lnlNot2);
            this.tbTemsilci2.Controls.Add(this.txtNot2);
            this.tbTemsilci2.Controls.Add(this.Temsilci_Durum2);
            this.tbTemsilci2.Controls.Add(this.btnCagriSonlandir2);
            this.tbTemsilci2.Location = new System.Drawing.Point(4, 29);
            this.tbTemsilci2.Name = "tbTemsilci2";
            this.tbTemsilci2.Padding = new System.Windows.Forms.Padding(3);
            this.tbTemsilci2.Size = new System.Drawing.Size(808, 293);
            this.tbTemsilci2.TabIndex = 1;
            this.tbTemsilci2.Text = "Temsilci 2";
            this.tbTemsilci2.UseVisualStyleBackColor = true;
            // 
            // lnlNot2
            // 
            this.lnlNot2.AutoSize = true;
            this.lnlNot2.Location = new System.Drawing.Point(28, 228);
            this.lnlNot2.Name = "lnlNot2";
            this.lnlNot2.Size = new System.Drawing.Size(84, 20);
            this.lnlNot2.TabIndex = 11;
            this.lnlNot2.Text = "Cagri Notu:";
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(118, 225);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(125, 27);
            this.txtNot2.TabIndex = 11;
            // 
            // Temsilci_Durum2
            // 
            this.Temsilci_Durum2.FormattingEnabled = true;
            this.Temsilci_Durum2.ItemHeight = 20;
            this.Temsilci_Durum2.Location = new System.Drawing.Point(13, 16);
            this.Temsilci_Durum2.Name = "Temsilci_Durum2";
            this.Temsilci_Durum2.Size = new System.Drawing.Size(433, 244);
            this.Temsilci_Durum2.TabIndex = 6;
            // 
            // btnCagriSonlandir2
            // 
            this.btnCagriSonlandir2.Location = new System.Drawing.Point(663, 225);
            this.btnCagriSonlandir2.Name = "btnCagriSonlandir2";
            this.btnCagriSonlandir2.Size = new System.Drawing.Size(112, 37);
            this.btnCagriSonlandir2.TabIndex = 5;
            this.btnCagriSonlandir2.Text = "Sonlandır";
            this.btnCagriSonlandir2.UseVisualStyleBackColor = true;
            this.btnCagriSonlandir2.Click += new System.EventHandler(this.btnCagriSonlandir2_Click);
            // 
            // tbTemsilci3
            // 
            this.tbTemsilci3.Controls.Add(this.txtNot3);
            this.tbTemsilci3.Controls.Add(this.lblNot3);
            this.tbTemsilci3.Controls.Add(this.Temsilci_Durum3);
            this.tbTemsilci3.Controls.Add(this.btnCagriSonlandir3);
            this.tbTemsilci3.Location = new System.Drawing.Point(4, 29);
            this.tbTemsilci3.Name = "tbTemsilci3";
            this.tbTemsilci3.Size = new System.Drawing.Size(808, 293);
            this.tbTemsilci3.TabIndex = 2;
            this.tbTemsilci3.Text = "Temsilci 3";
            this.tbTemsilci3.UseVisualStyleBackColor = true;
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(117, 225);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(125, 27);
            this.txtNot3.TabIndex = 9;
            // 
            // lblNot3
            // 
            this.lblNot3.AutoSize = true;
            this.lblNot3.Location = new System.Drawing.Point(27, 225);
            this.lblNot3.Name = "lblNot3";
            this.lblNot3.Size = new System.Drawing.Size(84, 20);
            this.lblNot3.TabIndex = 9;
            this.lblNot3.Text = "Cagri Notu:";
            // 
            // Temsilci_Durum3
            // 
            this.Temsilci_Durum3.FormattingEnabled = true;
            this.Temsilci_Durum3.ItemHeight = 20;
            this.Temsilci_Durum3.Location = new System.Drawing.Point(13, 16);
            this.Temsilci_Durum3.Name = "Temsilci_Durum3";
            this.Temsilci_Durum3.Size = new System.Drawing.Size(433, 244);
            this.Temsilci_Durum3.TabIndex = 7;
            // 
            // btnCagriSonlandir3
            // 
            this.btnCagriSonlandir3.Location = new System.Drawing.Point(663, 225);
            this.btnCagriSonlandir3.Name = "btnCagriSonlandir3";
            this.btnCagriSonlandir3.Size = new System.Drawing.Size(112, 37);
            this.btnCagriSonlandir3.TabIndex = 6;
            this.btnCagriSonlandir3.Text = "Sonlandır";
            this.btnCagriSonlandir3.UseVisualStyleBackColor = true;
            this.btnCagriSonlandir3.Click += new System.EventHandler(this.btnCagriSonlandir3_Click);
            // 
            // tbTemsilci4
            // 
            this.tbTemsilci4.Controls.Add(this.lblNot4);
            this.tbTemsilci4.Controls.Add(this.txtNot4);
            this.tbTemsilci4.Controls.Add(this.Temsilci_Durum4);
            this.tbTemsilci4.Controls.Add(this.btnCagriSonlandir4);
            this.tbTemsilci4.Location = new System.Drawing.Point(4, 29);
            this.tbTemsilci4.Name = "tbTemsilci4";
            this.tbTemsilci4.Size = new System.Drawing.Size(808, 293);
            this.tbTemsilci4.TabIndex = 3;
            this.tbTemsilci4.Text = "Temsilci 4";
            this.tbTemsilci4.UseVisualStyleBackColor = true;
            // 
            // lblNot4
            // 
            this.lblNot4.AutoSize = true;
            this.lblNot4.Location = new System.Drawing.Point(24, 225);
            this.lblNot4.Name = "lblNot4";
            this.lblNot4.Size = new System.Drawing.Size(84, 20);
            this.lblNot4.TabIndex = 5;
            this.lblNot4.Text = "Cagri Notu:";
            // 
            // txtNot4
            // 
            this.txtNot4.Location = new System.Drawing.Point(114, 222);
            this.txtNot4.Name = "txtNot4";
            this.txtNot4.Size = new System.Drawing.Size(125, 27);
            this.txtNot4.TabIndex = 5;
            // 
            // Temsilci_Durum4
            // 
            this.Temsilci_Durum4.FormattingEnabled = true;
            this.Temsilci_Durum4.ItemHeight = 20;
            this.Temsilci_Durum4.Location = new System.Drawing.Point(13, 16);
            this.Temsilci_Durum4.Name = "Temsilci_Durum4";
            this.Temsilci_Durum4.Size = new System.Drawing.Size(442, 244);
            this.Temsilci_Durum4.TabIndex = 8;
            // 
            // btnCagriSonlandir4
            // 
            this.btnCagriSonlandir4.Location = new System.Drawing.Point(663, 225);
            this.btnCagriSonlandir4.Name = "btnCagriSonlandir4";
            this.btnCagriSonlandir4.Size = new System.Drawing.Size(112, 35);
            this.btnCagriSonlandir4.TabIndex = 7;
            this.btnCagriSonlandir4.Text = "Sonlandır";
            this.btnCagriSonlandir4.UseVisualStyleBackColor = true;
            this.btnCagriSonlandir4.Click += new System.EventHandler(this.btnCagriSonlandir4_Click);
            // 
            // btnCagriEkle
            // 
            this.btnCagriEkle.Location = new System.Drawing.Point(519, 669);
            this.btnCagriEkle.Name = "btnCagriEkle";
            this.btnCagriEkle.Size = new System.Drawing.Size(224, 51);
            this.btnCagriEkle.TabIndex = 3;
            this.btnCagriEkle.Text = "Cagri Ekle";
            this.btnCagriEkle.UseVisualStyleBackColor = true;
            this.btnCagriEkle.Click += new System.EventHandler(this.btnCagriEkle_Click);
            // 
            // Bekleyen_Musteriler
            // 
            this.Bekleyen_Musteriler.FormattingEnabled = true;
            this.Bekleyen_Musteriler.ItemHeight = 20;
            this.Bekleyen_Musteriler.Location = new System.Drawing.Point(230, 15);
            this.Bekleyen_Musteriler.Name = "Bekleyen_Musteriler";
            this.Bekleyen_Musteriler.Size = new System.Drawing.Size(816, 244);
            this.Bekleyen_Musteriler.TabIndex = 2;
            // 
            // tbCagri_Kayitlari
            // 
            this.tbCagri_Kayitlari.Controls.Add(this.Kayitlar);
            this.tbCagri_Kayitlari.Location = new System.Drawing.Point(4, 29);
            this.tbCagri_Kayitlari.Name = "tbCagri_Kayitlari";
            this.tbCagri_Kayitlari.Size = new System.Drawing.Size(1345, 738);
            this.tbCagri_Kayitlari.TabIndex = 2;
            this.tbCagri_Kayitlari.Text = "Çağrı Kayıt ve Notları";
            this.tbCagri_Kayitlari.UseVisualStyleBackColor = true;
            // 
            // Kayitlar
            // 
            this.Kayitlar.FormattingEnabled = true;
            this.Kayitlar.ItemHeight = 20;
            this.Kayitlar.Location = new System.Drawing.Point(68, 63);
            this.Kayitlar.Name = "Kayitlar";
            this.Kayitlar.Size = new System.Drawing.Size(1145, 584);
            this.Kayitlar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 773);
            this.Controls.Add(this.tbGenel);
            this.Name = "Form1";
            this.Text = "Cagri Merkezi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbGenel.ResumeLayout(false);
            this.tbMusteriArama.ResumeLayout(false);
            this.tbMusteriArama.PerformLayout();
            this.tbAramaCevap.ResumeLayout(false);
            this.tbTemsilciler.ResumeLayout(false);
            this.tbTemsilci1.ResumeLayout(false);
            this.tbTemsilci1.PerformLayout();
            this.tbTemsilci2.ResumeLayout(false);
            this.tbTemsilci2.PerformLayout();
            this.tbTemsilci3.ResumeLayout(false);
            this.tbTemsilci3.PerformLayout();
            this.tbTemsilci4.ResumeLayout(false);
            this.tbTemsilci4.PerformLayout();
            this.tbCagri_Kayitlari.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbGenel;
        private System.Windows.Forms.TabPage tbMusteriArama;
        private System.Windows.Forms.TabPage tbAramaCevap;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.RadioButton rdoBireysel;
        private System.Windows.Forms.RadioButton rdoTicari;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox Bekleyen_Musteriler;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnCagriSonlandir3;
        private System.Windows.Forms.Button btnCagriSonlandir4;
        private System.Windows.Forms.Button btnCagriSonlandir2;
        private System.Windows.Forms.TabControl tbTemsilciler;
        private System.Windows.Forms.TabPage tbTemsilci1;
        private System.Windows.Forms.TabPage tbTemsilci2;
        private System.Windows.Forms.TabPage tbTemsilci3;
        private System.Windows.Forms.TabPage tbTemsilci4;
        private System.Windows.Forms.Button btnCagriSonlandir1;
        private System.Windows.Forms.Button btnCagriEkle;
        private System.Windows.Forms.ListBox Temsilci_Durum;
        private System.Windows.Forms.ListBox Temsilci_Durum2;
        private System.Windows.Forms.ListBox Temsilci_Durum3;
        private System.Windows.Forms.ListBox Temsilci_Durum4;
        private System.Windows.Forms.Label lblNot4;
        private System.Windows.Forms.TextBox txtNot4;
        private System.Windows.Forms.Label lblNot1;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.Label lnlNot2;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.Label lblNot3;
        private System.Windows.Forms.TabPage tbCagri_Kayitlari;
        private System.Windows.Forms.ListBox Kayitlar;
    }
}

