using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //Pascal Case  //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager(); //ProductManager türündeki productManager yeni bir referans numarası almış ProductManager dır demek! Eşitliğin (=) in sol tarafı stack, sağ tarafı heap tir, orada oluşmuş oldular.örnek oluşturma-(instance creation) 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //////productManager.Topla2(3, 6);

            //////int toplamaSonucu = productManager.Topla(3, 6);

            //////Console.WriteLine(toplamaSonucu*2);
            ////////Console.WriteLine(productManager.Topla(3, 6)/2);      


            //int, double, bool... değer tip
            //diziler, class, abstract class, interface ... referans tip
        }
    }
}
