using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.MusteriNo = 1;
            Musteri1.MusteriAdi = "Ali";
            Musteri1.MusteriSoyadi = "Bir";
            Musteri1.MusteriTelefon = "5551234567";
            Musteri1.MusteriAdres = "İstanbul";
            Musteri Musteri2 = new Musteri();
            Musteri2.MusteriNo = 2;
            Musteri2.MusteriAdi = "Berna";
            Musteri2.MusteriSoyadi = "İki";
            Musteri2.MusteriTelefon = "5550234567";
            Musteri2.MusteriAdres = "Ankara";
            Musteri Musteri3 = new Musteri();
            Musteri3.MusteriNo = 3;
            Musteri3.MusteriAdi = "Celil";
            Musteri3.MusteriSoyadi = "Üç";
            Musteri3.MusteriTelefon = "5551034567";
            Musteri3.MusteriAdres = "Bolu";
            Musteri Musteri4 = new Musteri();
            Musteri4.MusteriNo = 4;
            Musteri4.MusteriAdi = "Deniz";
            Musteri4.MusteriSoyadi = "Dört";
            Musteri4.MusteriTelefon = "5554034567";
            Musteri4.MusteriAdres = "İzmir";

            Musteri[] Musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            //Musteri4 ekleniyor
            Musteriler =musteriManager.MusteriEkle(Musteri4,Musteriler);
            //Musteri2 siliniyor
            Musteriler = musteriManager.MusteriSil(Musteri2,Musteriler);           
            //Müşteriler Listeleniyor
            musteriManager.MusteriListele(Musteriler);

            
        }
    }
}
