using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3]; //string[] students = new string[3] { "tuğçe", "salih", "ali" }; şeklinde tanımlasaydık students[0],students[1],students[2] yi ayrıca yazmamıza gerek kalmazdı.
            students[0] = "tuğçe";
            students[1] = "salih";
            students[2] = "ali";

            //string[] students2 = new[] { "tuğçe", "salih", "ali" }; //böyle de yazılabilir
            //string[] students2 = { "tuğçe", "salih", "ali" }; //bu şekilde de

            foreach (var student in students) //arrayin her elemanını gezmek için kullanılır.
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
