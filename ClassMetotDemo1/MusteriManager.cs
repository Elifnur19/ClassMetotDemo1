using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void Add(Musteri Musteri)
        {
            Console.WriteLine("Adı:" + Musteri.Adi + " " + "Soyadı:" + Musteri.Soyadi + " " + "Id:" + Musteri.Id + " ");
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Delete(Musteri Musteri)
        {
            Console.WriteLine("Adı:" + Musteri.Adi + " " + "Soyadı:" + Musteri.Soyadi + " " + "Id:" + Musteri.Id + " ");
            Console.WriteLine("Müşteri silindi.");

        }

        public void List(Musteri Musteri)
        {
            Console.WriteLine("Adı:" + Musteri.Adi + " " + "Soyadı:" + Musteri.Soyadi + " " + "Id:" + Musteri.Id + " ");
            Console.WriteLine("Müşteri listesi");

        }
    }
}
