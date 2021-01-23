using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "Galatasaray";
            musteri1.Isim = "Fernando";
            musteri1.Soyisim = "Muslera";
            musteri1.MusteriNo = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "Galatasaray";
            musteri2.Isim = "Arda";
            musteri2.Soyisim = "Turan";
            musteri2.MusteriNo = 66;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "Galatasaray";
            musteri3.Isim = "Fatih";
            musteri3.Soyisim = "Terim";
            musteri3.MusteriNo = 10;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();


            foreach (Musteri  musteri in musteriler)
            {
                musteriManager.AddMusteri(musteri);
            }

            Console.WriteLine(".........................");



            foreach (Musteri musteri in musteriler)   
            {
                musteriManager.ShowMusteri(musteri);
                Console.WriteLine("........................");
            }
        }
    }
}
