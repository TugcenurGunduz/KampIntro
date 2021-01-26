using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "programlamaya Giriş";
            string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] {
            "Yazılım Geliştirici Yetiştirme Kursu",
            "programlamaya Giriş",
            "java",
            "python",
            "C++",
            "C#"
            };

            //for yapısı

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //foreach - dizi temelli yapıları tek tek dönmeye yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
