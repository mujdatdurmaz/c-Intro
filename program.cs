using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sayi3, toplam;
            double ort;
            Console.WriteLine("1. sayıyı giriniz .");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz .");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı giriniz .");
            sayi3 = Convert.ToInt32(Console.ReadLine());

           ort = (sayi1 + sayi2 + sayi3) / 3;
         
   
           // toplam = sayi1 + sayi2 + sayi3;
           // ort = toplam / 3;

            Console.Write("Ortalama Sonucu = " + ort);

            Console.ReadKey();

        }
    }
}
