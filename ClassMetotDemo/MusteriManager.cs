using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine($"Müşteri eklenmiştir : {musteri.Adi}  {musteri.Soyadi}" +
                $" - {musteri.Yasi} - {musteri.Numara}");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine($"Müşteri silinmiştir : {musteri.Adi}  {musteri.Soyadi}" +
                $" - {musteri.Yasi} - {musteri.Numara}");
        }
        public void Liste(Musteri[] musteri)
        {
            Console.WriteLine("****Müşteri Bilgileri****");
            Console.WriteLine();
            foreach (var item in musteri)
            {
                Console.WriteLine($"Adı - Soyadı: {item.Adi} {item.Soyadi}");
                Console.WriteLine($"Yaşı : {item.Yasi}");
                Console.WriteLine($"Numarası : {item.Numara}");
                Console.WriteLine();
            }
        }
    }
}
