using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Hasan";
            musteri1.Soyad = "Aktaş";
            musteri1.Telefon = 545671;
            musteri1.Adres = "Antalya";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Esin";
            musteri2.Soyad = "Öztekin";
            musteri2.Telefon = 541238;
            musteri2.Adres = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ege";
            musteri3.Soyad = "Kaya";
            musteri3.Telefon = 542967;
            musteri3.Adres = "Adana";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Ela";
            musteri4.Soyad = "Tuğrul";
            musteri4.Telefon = 541267;
            musteri4.Adres = "Bursa";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Ad = "Zeynep";
            musteri5.Soyad = "Tekin";
            musteri5.Telefon = 545623;
            musteri5.Adres = "İzmir";
            
                
            musteriManager.Add(musteri5);
            musteriManager.Remove(musteri4);
            musteriManager.List(musteriler);

        }

    }
}
