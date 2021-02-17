using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add( Musteri musteri)
        {
            Console.WriteLine("Musteri id :" +musteri.Id);
            Console.WriteLine("Musteri Ad :" +musteri.Ad);
            Console.WriteLine("Musteri Soyad :" +musteri.Soyad);
            Console.WriteLine("Musteri Telefon :" +musteri.Telefon);
            Console.WriteLine("Musteri Adres :" +musteri.Adres);
            Console.WriteLine("Muşteri  başarıyla eklendi");
            Console.WriteLine("*******************");
        }
        

        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Musteri id :" + musteri.Id);
            Console.WriteLine("Musteri Ad :" + musteri.Ad);
            Console.WriteLine("Musteri Soyad :" + musteri.Soyad);
            Console.WriteLine("Musteri Telefon :" + musteri.Telefon);
            Console.WriteLine("Musteri Adres :" + musteri.Adres);
            Console.WriteLine("Muşteri başarıyla kaldırıldı");
            Console.WriteLine("*******************");
        }


        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri id :" + musteri.Id);
                Console.WriteLine("Musteri Ad :" + musteri.Ad);
                Console.WriteLine("Musteri Soyad :" + musteri.Soyad);
                Console.WriteLine("Musteri Telefon :" + musteri.Telefon);
                Console.WriteLine("Musteri Adres :" + musteri.Adres);
                Console.WriteLine("*******************");

            }


        }
        
    }
}
