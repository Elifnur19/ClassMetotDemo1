using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0338297;
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Mandal";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 7236846;
            musteri2.Adi = "Zeynep";
            musteri2.Soyadi = "Tatlı";

            MusteriManager musterimanager = new MusteriManager();
            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri Musteri in Musteriler)
            {
                musterimanager.List(Musteri);
            }

            musterimanager.Add(musteri2);
            musterimanager.Delete(musteri1);

        }
    }
    
}
