using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11111;
            musteri1.Name = "Mustafa";
            musteri1.Surname = "Genç";
            musteri1.Birthday = 1997;
            musteri1.Password = 1111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 22222;
            musteri2.Name = "Elif";
            musteri2.Surname = "Kaya";
            musteri2.Birthday = 1994;
            musteri2.Password = 2222;


            Musteri[] musteri = new Musteri[] { };


            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Id);
                Console.WriteLine(musteriler.Name);
                Console.WriteLine(musteriler.Surname);
                Console.WriteLine(musteriler.Password);
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            Console.WriteLine("------------------------------------");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("------------------------------------");

            musteriManager.MusteriDüzenleme(musteri1);
            musteriManager.MusteriDüzenleme(musteri2);

            Console.WriteLine("------------------------------------");

            musteriManager.MusterileriListele(musteri1, musteri2);

        }
    }
}
