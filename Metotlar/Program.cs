using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1=new Urunler();
            urun1.Ad = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urunler urun2=new Urunler();
            urun2.Ad = "Karpuz";
            urun2.Fiyati = 90;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urunler[] urunler=new Urunler[]{urun1, urun2};

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-----------");

            }

            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
