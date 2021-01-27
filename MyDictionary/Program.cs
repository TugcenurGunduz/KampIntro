using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> citys = new MyDictionary<int, string>();
            citys.Add(34, "İstanbul");
            citys.Add(06, "Ankara");
            citys.Add(78, "Karabük");

            foreach (var value in citys.tvalues)
            {
                Console.WriteLine(value);
            }
            foreach (var key in citys.tkeys)
            {
                Console.WriteLine(key);
            }

        }
    }
}