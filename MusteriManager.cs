using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " Adlı Müşteri Eklendi");
        }

        public void ShowMusteri(Musteri musteri)
        {
            Console.WriteLine("Id : "+musteri.Id );
            Console.WriteLine("İsim : " + musteri.Isim);
            Console.WriteLine("Soyisim : "+musteri.Soyisim);
            Console.WriteLine("Müşteri No : "+musteri.MusteriNo);
        }
    }
}
