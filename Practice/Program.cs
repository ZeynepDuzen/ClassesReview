using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba sinifi
            Araba arb = new Araba();
            arb.marka = "X";
            arb.model = "2022";
            arb.hiz = 180;
            arb.motor = 1.6;
            arb.renk = "Beyaz";

            Console.WriteLine("*** Araba Tanitim ***");
            Console.WriteLine();
            Console.WriteLine("Marka : " + arb.marka);
            Console.WriteLine("Model : " + arb.model);
            Console.WriteLine("Hiz : " + arb.hiz);
            Console.WriteLine("Motor : " + arb.motor);
            Console.WriteLine("Renk : " + arb.renk);

            //Musteri sinifi
            Musteri mstr = new Musteri();
            mstr.id = 1;
            mstr.ad = "Zeynep";
            mstr.soyad = "Cankus";
            mstr.sehir = "CankusKoyu";

            Console.WriteLine("*** Musteri Bilgileri ***");
            Console.WriteLine();
            Console.WriteLine("Musteri id :" + mstr.id);
            Console.WriteLine("Müsteri ad : " + mstr.ad);
            Console.WriteLine("Musteri soyad : " + mstr.soyad);
            Console.WriteLine("Musteri sehir : " +mstr.sehir);



            Console.Read();
        }
    }
}
