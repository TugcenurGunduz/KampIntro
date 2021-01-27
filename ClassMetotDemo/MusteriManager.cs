using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("EKLEME");
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Name + "\n" + musteri.Surname + "\n" + musteri.Birthday + "\n" + musteri.Password);
            Console.WriteLine("Müşteri Eklendi!");
            Console.WriteLine(" ");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("SİLME");
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Name + "\n" + musteri.Surname + "\n" + musteri.Birthday + "\n");
            Console.WriteLine(" ");
            Console.WriteLine("Müşteri Silindi!");
            Console.WriteLine(" ");
        }

        public void MusteriDüzenleme(Musteri musteri)
        {
            Console.WriteLine("DÜZENLEME");
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Name + "\n" + musteri.Surname + "\n" + musteri.Birthday + "\n" + musteri.Password);
            Console.WriteLine(" ");
            Console.WriteLine("Müşteri Güncellendi!");
            Console.WriteLine(" ");
        }
        public void MusterileriListele(params Musteri[] musteri)
        {
            Console.WriteLine("MÜŞTERİ LİSTESİ");
            Console.WriteLine(" ");
            if (musteri.Length > 0)
            {
                foreach (var Musteri in musteri)
                {
                    Console.WriteLine($"Id: {Musteri.Id}");
                    Console.WriteLine($"İsim: {Musteri.Name}");
                    Console.WriteLine($"Soyisim: {Musteri.Surname}");
                    Console.WriteLine($"Doğum Tarihi: {Musteri.Birthday}");
                    Console.WriteLine($"Şifre: {Musteri.Password}");
                    Console.WriteLine("------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Müşteri Bulunamadı!");
            }
        }
    }
}