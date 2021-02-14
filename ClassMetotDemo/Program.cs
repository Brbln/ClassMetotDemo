using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri()
            {
                Adi = "Ahmet",
                Soyadi = "YAŞAR",
                Yasi = 25,
                Numara = 01234569778
            };

            Musteri musteri2 = new Musteri()
            {
                Adi = "Aslı",
                Soyadi = "BİRBİLEN",
                Yasi = 19,
                Numara = 1234687454
            };
            Musteri musteri3 = new Musteri()
            {
                Adi = "Betül",
                Soyadi = "AK",
                Yasi = 40,
                Numara = 02123461587
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine();

            //Ekleme
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine();

            //Silme
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            Console.WriteLine();

            //Listeleme
            musteriManager.Liste(musteriler);
        }
    }
}
