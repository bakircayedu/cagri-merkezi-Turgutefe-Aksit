using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cagri_Merkezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<Musteri> musteriler = new List<Musteri>();
        //List<MusteriTemsilci> temsilciler = new List<MusteriTemsilci>();
        MyLinkedList<Musteri> musteriBekleyenList = new MyLinkedList<Musteri>();

        Cagri cagri = new Cagri();
        MyLinkedList<Cagri> CagriList = new MyLinkedList<Cagri>();

        MusteriTemsilci temsilci1 = new MusteriTemsilci();
        MusteriTemsilci temsilci2 = new MusteriTemsilci();
        MusteriTemsilci temsilci3 = new MusteriTemsilci();
        MusteriTemsilci temsilci4 = new MusteriTemsilci();

        private void Form1_Load(object sender, EventArgs e)
        {
            temsilci1.Isim = "Turgutefe";
            temsilci1.SoyIsim = "Akşit";
            temsilci1.TemsilciNumarasi = 1;
            temsilci1.tur = Tur.Bireysel;

            temsilci2.Isim = "Aysel";
            temsilci2.SoyIsim = "Karpuz";
            temsilci2.TemsilciNumarasi = 2;
            temsilci2.tur = Tur.Bireysel;

            temsilci3.Isim = "Muhamment";
            temsilci3.SoyIsim = "Akyol";
            temsilci3.TemsilciNumarasi = 3;
            temsilci3.tur = Tur.Ticari;

            temsilci4.Isim = "Kerem";
            temsilci4.SoyIsim = "Bora";
            temsilci4.TemsilciNumarasi = 4;
            temsilci4.tur = Tur.Ticari;

            temsilciUpdate();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Cagri cagri = new Cagri();
            Musteri musteri = new Musteri();
            musteri.Isim = txtMusteriAd.Text;
            musteri.SoyIsim = txtSoyad.Text;
            musteri.TelNo = txtTelNo.Text;
            musteri.MusteriNo = musteriBekleyenList.Size + 1;

            if (rdoBireysel.Checked == true)
            {
                musteri.tur = Tur.Bireysel;
            }
            else
            {
                musteri.tur = Tur.Ticari;
            }

            cagri.musteri = musteri;
            cagri.zamanBaslangic = dtPicker.Value;
            CagriList.Insert(cagri);

            musteriBekleyenList.Insert(musteri);
            bekleyenMusteriListeYazdir();
        }

        
        //Girilen müşteri bilgileri doğrultusunda beklemeyen müşteriler listesine müşteri eklenir.
        private void btnCagriEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in musteriBekleyenList.DisplayElements())
            {
                if (item.tur == Tur.Bireysel && temsilci1.Durum == ENDurum.Musait)
                {
                    musteriBekleyenList.Delete(item);
                    temsilci1.Durum = ENDurum.Mesgul;
                    temsilci1.musteri = item;
                    cagri.musteriTemsilci = temsilci1;
                    cagri.musteri = item;
                    temsilciUpdate();
                    bekleyenMusteriListeYazdir();
                }
                else if (item.tur == Tur.Bireysel && temsilci2.Durum == ENDurum.Musait)
                {
                    musteriBekleyenList.Delete(item);
                    temsilci2.Durum = ENDurum.Mesgul;
                    temsilci2.musteri = item;
                    cagri.musteriTemsilci = temsilci2;
                    cagri.musteri = item;
                    temsilciUpdate();
                    bekleyenMusteriListeYazdir();
                }
                else if (item.tur == Tur.Ticari && temsilci3.Durum == ENDurum.Musait)
                {
                    musteriBekleyenList.Delete(item);
                    temsilci3.Durum = ENDurum.Mesgul;
                    temsilci3.musteri = item;
                    cagri.musteriTemsilci = temsilci3;
                    cagri.musteri = item;
                    temsilciUpdate();
                    bekleyenMusteriListeYazdir();
                }
                else if (item.tur == Tur.Ticari && temsilci4.Durum == ENDurum.Musait)
                {
                    musteriBekleyenList.Delete(item);
                    temsilci4.Durum = ENDurum.Mesgul;
                    temsilci4.musteri = item;
                    cagri.musteriTemsilci = temsilci4;
                    cagri.musteri = item;
                    temsilciUpdate();
                    bekleyenMusteriListeYazdir();
                }
            }
            
        }
        //public void bekleyenMusteriSil(Musteri musteri)
        //{
        //    foreach (var item in musteriBekleyenList.DisplayElements())
        //    {
        //        if (item.MusteriNo == musteri.MusteriNo)
        //        {
        //            musteriBekleyenList.Delete(item)
        //        }
        //    }
        //}
        public void temsilciUpdate()
        {
            Temsilci_Durum.Items.Clear();
            Temsilci_Durum2.Items.Clear();
            Temsilci_Durum3.Items.Clear();
            Temsilci_Durum4.Items.Clear();
            Temsilci_Durum.Items.Add("Temsilci Adi: " + temsilci1.Isim);
            Temsilci_Durum.Items.Add("Temsilci Soyadi: " + temsilci1.SoyIsim);
            Temsilci_Durum.Items.Add("Temsilci Türü: " + temsilci1.tur);
            Temsilci_Durum.Items.Add("Temsilci Durumu: " + temsilci1.Durum);
            if (temsilci1.Durum == ENDurum.Mesgul)
            {
                
            }


            Temsilci_Durum2.Items.Add("Temsilci Adi: " + temsilci2.Isim);
            Temsilci_Durum2.Items.Add("Temsilci Soyadi: " + temsilci2.SoyIsim);
            Temsilci_Durum2.Items.Add("Temsilci Türü: " + temsilci2.tur);
            Temsilci_Durum2.Items.Add("Temsilci Durumu: " + temsilci2.Durum);

            Temsilci_Durum3.Items.Add("Temsilci Adi: " + temsilci3.Isim);
            Temsilci_Durum3.Items.Add("Temsilci Soyadi: " + temsilci3.SoyIsim);
            Temsilci_Durum3.Items.Add("Temsilci Türü: " + temsilci3.tur);
            Temsilci_Durum3.Items.Add("Temsilci Durumu: " + temsilci3.Durum);

            Temsilci_Durum4.Items.Add("Temsilci Adi: " + temsilci4.Isim);
            Temsilci_Durum4.Items.Add("Temsilci Soyadi: " + temsilci4.SoyIsim);
            Temsilci_Durum4.Items.Add("Temsilci Türü: " + temsilci4.tur);
            Temsilci_Durum4.Items.Add("Temsilci Durumu: " + temsilci4.Durum);
        }

        //Bekleyen müşterileri listboxa yazdırır.
        public void bekleyenMusteriListeYazdir()
        {
            Bekleyen_Musteriler.Items.Clear();

            foreach (var item in musteriBekleyenList.DisplayElements())
            {
                Bekleyen_Musteriler.Items.Add("Musteri Adi: " + item.Isim);
                Bekleyen_Musteriler.Items.Add("Musteri Soyadi: " + item.SoyIsim);
                Bekleyen_Musteriler.Items.Add("Musteri Numarasi: " + item.MusteriNo);
                Bekleyen_Musteriler.Items.Add("Musteri Tel No: " + item.TelNo);
                Bekleyen_Musteriler.Items.Add(" " + "-" + " ");
            }
        }


        //sesçilen temsilci eğer çağrıda ise çağrısı bitirilir.
        private void btnCagriSonlandir1_Click(object sender, EventArgs e)
        {
            if (temsilci1.Durum == ENDurum.Mesgul)
            {
                foreach (var item in CagriList.DisplayElements())
                {
                    if (item.musteri == temsilci1.musteri)
                    {
                        item.zamanBitis = DateTime.Now;
                        item.Not = txtNot1.Text;
                        CagriList.Insert(item);
                        temsilci1.musteri = null;
                    }
                }
                temsilci1.Durum = ENDurum.Musait;
            }
            temsilciUpdate();

        }
        private void btnCagriSonlandir2_Click(object sender, EventArgs e)
        {
            if (temsilci2.Durum == ENDurum.Mesgul)
            {
                foreach (var item in CagriList.DisplayElements())
                {
                    if (item.musteri == temsilci2.musteri)
                    {
                        item.zamanBitis = DateTime.Now;
                        item.Not = txtNot2.Text;
                        CagriList.Insert(item);
                        temsilci2.musteri = null;
                    }
                }
                temsilci2.Durum = ENDurum.Musait;
            }
            temsilciUpdate();
        }

        private void btnCagriSonlandir3_Click(object sender, EventArgs e)
        {
            if (temsilci3.Durum == ENDurum.Mesgul)
            {
                foreach (var item in CagriList.DisplayElements())
                {
                    if (item.musteri == temsilci3.musteri)
                    {
                        item.zamanBitis = DateTime.Now;
                        item.Not = txtNot3.Text;
                        CagriList.Insert(item);
                        temsilci3.musteri = null;
                    }
                }
                temsilci3.Durum = ENDurum.Musait;
            }
            temsilciUpdate();
        }

        private void btnCagriSonlandir4_Click(object sender, EventArgs e)
        {
            if (temsilci4.Durum == ENDurum.Mesgul)
            {
                foreach (var item in CagriList.DisplayElements())
                {
                    if (item.musteri == temsilci4.musteri)
                    {
                        item.zamanBitis = DateTime.Now;
                        item.Not = txtNot4.Text;
                        CagriList.Insert(item);
                        temsilci4.musteri = null;
                    }
                }
                temsilci4.Durum = ENDurum.Musait;
            }
            temsilciUpdate();
        }
    }
}
