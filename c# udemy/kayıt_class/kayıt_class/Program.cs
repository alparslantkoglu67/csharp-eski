using System;

namespace kayıt_class
{
    class Program
    {
        static void Main(string[] args)
        {
            enbas:
            Kayit kyt = new Kayit();
            Console.Write("Adınızı Giriniz:    " + " ");
            kyt.Isim = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz: " + " ");
            kyt.Soyisim = Console.ReadLine();
            Console.Write("Yaşınızı Giriniz:   " + " ");
            kyt.Yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mesleğinizi Giriniz:" + " ");
            kyt.Meslek = Console.ReadLine();
            Console.WriteLine("-------------------------");
            kyt.liste();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Başka bir kayıt için lütfen g tuşuna basın...");
            char geri=Convert.ToChar(Console.ReadLine());
            if (geri=='g'|| geri == 'G')
            {
                goto enbas;
            }
            Console.ReadKey();

        }
    }
}
