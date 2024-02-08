using System;

namespace uygu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. VE 2. SINAVLARINIZ %25 FİNAL İSE %50 ETKİ ETMEKTEDİR ");
            Console.WriteLine("1.sınav notunu giriniz:");
            int ilk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sınav notunu giriniz");
            int iki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());

            double toplam = (ilk * (1 / 4)) + (iki * (1 / 4)) + (final * (1 / 2));
            if (toplam >= 50)
            {
                Console.WriteLine("Başarıyla geçtiniz" + "Notunuz: " + toplam);
            }
            if(toplam>=0 && toplam<=49)
            {
                Console.WriteLine("Malesef kaldınız" + "Notunuz:"+toplam);
            }
            Console.ReadKey();
        }
    }
}
