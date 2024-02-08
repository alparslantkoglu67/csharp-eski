using System;

namespace Kayıt_class_yapıcı
{



    
    class Program
    
    {
        
        static void Main(string[] args)
        
        {
            enbas:
            



            string isim;
            string soyisim;
            string meslek;
            int yas;
            Console.Write("Adınızı Giriniz:      ");
            isim = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz:    ");
            soyisim = Console.ReadLine();
            Console.Write("Yaşınızı Giriniz:     ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mesleğinizi Giriniz:  ");
            meslek = Console.ReadLine();
            Console.WriteLine("-------------------------------------" + "\n" + "-------------------------------------");
            
            Kayit kyt = new Kayit(isim,soyisim,yas,meslek);




            
            char geri = Convert.ToChar(Console.ReadLine());
            if (geri == 'g' || geri == 'G')
            {
                int sayac = 1;
                sayac++;
                Console.WriteLine(sayac);
                Console.WriteLine("-------------------------------------" + "\n" + "-------------------------------------");
                goto enbas;
            }

           
            Console.ReadKey();





           
        }
    }
}


                

                

            