﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Tuğçe";  
            int yas = 23;

            //class değerleri atadık

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Tuğçe Nur Gündüz";
            kurs1.IzlenmeOrani = "36";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = "64";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = "73";




            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            //string[] kurslar = new string[] { };  burada sadece string değer tutulabilir

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            //burada ise kurs tipinde tüm verileri yazdırabiliriz. içinde hangi tür veri varsa.

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + ":" + Kurs.Egitmen);
            }

        }
    }

    //class tanımladık
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }
    }
}
