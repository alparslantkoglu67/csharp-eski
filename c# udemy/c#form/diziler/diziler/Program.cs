using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        /*{
            int[] sayilar = { 20, 3, 62, 71, 21, 18, 94, 46, 39, 88 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > 10 && sayilar[i] % 2 == 0)
                    Console.WriteLine(sayilar[i]);
                
            }
            Console.ReadKey();
        }*/
        {
            //foreach********************
            int toplam = 0;
            int[] sayilar={12,46,88,96,52,76,53,18,68,31};
            Console.WriteLine("4'e bölünenler:");
            Console.WriteLine("---------------");
            foreach (int x in sayilar)
            {
                
                if (x % 4 == 0) 
                {
                    
                    Console.WriteLine(x);
                    Console.WriteLine("---------------");
                    toplam = toplam + x;
                    Console.WriteLine(toplam);


                }
                






               
            }








            


        }
    }
}
