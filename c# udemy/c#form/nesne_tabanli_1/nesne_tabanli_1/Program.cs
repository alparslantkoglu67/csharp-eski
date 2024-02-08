
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Girilen_sayının_çarpım_tablosu
{
    class Program
    {
        //www.bilisimkonulari.com
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Sayıyı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("------------------------------- ");

            //www.bilisimkonulari.com
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(sayi + " * " + i + " = " + sayi * i);
            }

            Console.ReadKey();
        }

        //www.bilisimkonulari.com
    }
}