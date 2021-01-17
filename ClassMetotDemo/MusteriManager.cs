using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public Musteri[] MusteriEkle(Musteri YeniMusteri, Musteri[] Musteriler1)
        {
            Musteri[] yeniMusteriler = new Musteri[Musteriler1.Length + 1];
            Musteriler1.CopyTo(yeniMusteriler, 0);
            yeniMusteriler[Musteriler1.Length] = YeniMusteri;
            Console.WriteLine("Müşrteri Eklendi" + YeniMusteri.MusteriAdi);
            return yeniMusteriler;
        }
        public Musteri[] MusteriSil(Musteri SilinenMusteri, Musteri[] Musteriler1)
        {
            Musteri[] yeniMusteriler = new Musteri[Musteriler1.Length - 1];
            int yindex = 0;
            for(int i = 0; i < Musteriler1.Length; i++)
            {
                if (Musteriler1[i].MusteriNo != SilinenMusteri.MusteriNo)
                {
                    yeniMusteriler[yindex] = Musteriler1[i];
                    yindex++;
                }
            }
            Console.WriteLine("Müşrteri Silindi" + SilinenMusteri.MusteriAdi);
            return yeniMusteriler;
        }
        public void MusteriListele(Musteri[] Musteriler)
        {
            foreach (Musteri musterii in Musteriler)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(musterii.MusteriNo);
                Console.WriteLine(musterii.MusteriAdi);
                Console.WriteLine(musterii.MusteriSoyadi);
                Console.WriteLine(musterii.MusteriTelefon);
                Console.WriteLine(musterii.MusteriAdres);
                Console.WriteLine("-----------------------------------");

            }
        }
    }
}
