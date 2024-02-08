using System;

namespace dort_islem_class
{
    class Program
    {
        static void Main(string[] args)
        {
        enbas:
            Console.WriteLine("Yapmak İstediğiniz İşlemi Tam Olarak Yazınız" + "\n" + "  TOPLAMA // ÇIKARMA // BÖLME // ÇARPMA // KALAN BULMA");
            Console.Write("İşlem:" + " ");
            string islemturu = Console.ReadLine();
           
            char geri;
            if (islemturu=="TOPLAMA")
            {

            
                Islem tpl = new Islem();
                Console.Write("Birinci değeri giriniz:" + "  ");
                double s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci  değeri giriniz:" + "  ");
                double s2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = tpl.Topla(s1, s2);
                Console.WriteLine("Sonuç="+" "+sonuc);
                Console.WriteLine("Tekrardan İşlem seçmek için g / G tuşuna basın...");
                geri = Convert.ToChar(Console.ReadLine());
                if (geri == 'g'&& geri=='G')
                {
                    goto enbas;
                }
            }
            if (islemturu == "ÇIKARMA")
            {


                Islem ckr = new Islem();
                Console.Write("Birinci değeri giriniz:" + "  ");
                double s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci  değeri giriniz:" + "  ");
                double s2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = ckr.Cikar(s1, s2);
                Console.WriteLine("Sonuç=" + " " + sonuc);
                Console.WriteLine("Tekrardan İşlem seçmek için g / G tuşuna basın...");
                geri = Convert.ToChar(Console.ReadLine());
                if (geri == 'g' && geri == 'G')
                {
                    goto enbas;
                }
            }
            if (islemturu == "ÇARPMA")
            {


                Islem crp = new Islem();
                Console.Write("Birinci değeri giriniz:" + "  ");
                double s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci  değeri giriniz:" + "  ");
                double s2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = crp.Carp(s1, s2);
                Console.WriteLine("Sonuç=" + " " + sonuc);
                Console.WriteLine("Tekrardan İşlem seçmek için g / G tuşuna basın...");
                geri = Convert.ToChar(Console.ReadLine());
                if (geri == 'g' && geri == 'G')
                {
                    goto enbas;
                }
            }
            if (islemturu == "BÖLME")
            {


                Islem bl = new Islem();
                Console.Write("Birinci değeri giriniz:" + "  ");
                double s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci  değeri giriniz:" + "  ");
                double s2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = bl.Bol(s1, s2);
                Console.WriteLine("Sonuç=" + " " + sonuc);
                Console.WriteLine("Tekrardan İşlem seçmek için g / G tuşuna basın...");
                geri = Convert.ToChar(Console.ReadLine());
                if (geri == 'g' && geri == 'G')
                {
                    goto enbas;
                }
            }
            if (islemturu == "KALAN BULMA")
            {


                Islem md = new Islem();
                Console.Write("Birinci değeri giriniz:" + "  ");
                double s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci  değeri giriniz:" + "  ");
                double s2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = md.Modal(s1, s2);
                Console.WriteLine("Sonuç=" + " " + sonuc);
                Console.WriteLine("Tekrardan İşlem seçmek için g / G tuşuna basın...");
                geri = Convert.ToChar(Console.ReadLine());
                if (geri == 'g' && geri == 'G')
                {
                    goto enbas;
                }
                else 
                {
                    Console.WriteLine("Seçmek istediğiniz işlemin ismini eksik veya hatalı yazdınız lütfen işlem seçmek için g//G tuşuna basınız ");
                if (geri == 'g' && geri == 'G')
                    {
                        goto enbas;
                    }
                }
            
            }

            Console.ReadKey();
            
            
            


        }
    }
}
