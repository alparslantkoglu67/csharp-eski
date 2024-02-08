using System;

namespace c_ders_calisma
{
    class Program
    {
        static void Main(string[] args)
        {
       
            string geri;
            
            Console.Write("Lütfen İsminizi Giriniz:"+"           ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen Soyisminizi Giriniz:"+"        ");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen Yaşınızı Giriniz:"+"           ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Mesleğinizi Giriniz:"+"        ");
            string meslek = Console.ReadLine();
            Console.Write("Lütfen Cinsiyetinizi Giriniz:(e/k)"+" ");
            string cinsiyet =Convert.ToString(Console.ReadLine());

            Kayit kisi = new Kayit(isim,soyisim,yas,meslek,cinsiyet);
            Console.WriteLine("---------------------------------------------------------" + "\n" + "---------------------------------------------------------");
            kisi.Bilgigöster();
            Console.WriteLine("            Tebrikler başarıyla kayıt oluşturdunuz!" + "\n" + "      Başka bir kayıt için k/K yazıp enter'a basınız...");
            geri = Console.ReadLine();
            
            
            

            
            
            


        }
    }
}
