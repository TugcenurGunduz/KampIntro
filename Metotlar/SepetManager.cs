using System;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) // Metot parametre alıyor. Urun->tipi, urun->aşağıda kullanacağım isimlendirme
        {
            Console.WriteLine("İşlem gerçekleşti, sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("İşlem gerçekleşti, sepete eklendi : " + urunAdi);
        }
    }
}
