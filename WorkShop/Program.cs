using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1;
            kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2=new Kurs();
            kurs2.KursAdi = "Phyton";
            kurs2.IzlenmeOranı = 52;
            kurs2.Egitmen = "Aysen";

            Kurs kurs3=new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Emre";
            kurs3.IzlenmeOranı = 14;


            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3
            };

            foreach (var kur in kurslar)
            {
                Console.WriteLine(kur.Egitmen);
            }   
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
