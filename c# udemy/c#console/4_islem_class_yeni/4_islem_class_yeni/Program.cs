using System;

namespace _4_islem_class_yeni
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            enbas:
                Console.WriteLine("Yapmak İstediğiniz İşlemi Tam Olarak Yazınız" + "\n" + "  TOPLAMA // ÇIKARMA // BÖLME // ÇARPMA // KALAN BULMA");
                Console.Write("İşlem:" + " ");
                string islemturu = Console.ReadLine();

                string geri;
                if (islemturu == "TOPLAMA")
                {


                    Islem tpl = new Islem();
                    Console.Write("Birinci değeri giriniz:" + "  ");
                    double s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("İkinci  değeri giriniz:" + "  ");
                    double s2 = Convert.ToInt32(Console.ReadLine());
                    double sonuc = tpl.Topla(s1, s2);
                    Console.WriteLine("Sonuç=" + " " + sonuc);
                    Console.WriteLine("Tekrardan İşlem seçmek için g yazıp enter'a basınız..");
                    geri = Convert.ToString(Console.ReadLine());
                    if (geri == "g")
                    {
                        goto enbas;
                    }
                }
                if (islemturu == "ÇIKARMA")
                {

                    Console.WriteLine("Not= Birinci değer - ikinci değer");
                    Islem ckr = new Islem();
                    Console.Write("Birinci değeri giriniz:" + "  ");
                    double s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("İkinci değeri giriniz:" + "  ");
                    double s2 = Convert.ToInt32(Console.ReadLine());
                    double sonuc = ckr.Cikar(s1, s2);
                    Console.WriteLine("Sonuç=" + " " + sonuc);
                    Console.WriteLine("Tekrardan İşlem seçmek için g yazıp enter'a basınız..");
                    geri = Convert.ToString(Console.ReadLine());
                    if (geri == "g")
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
                    Console.WriteLine("Tekrardan İşlem seçmek için g yazıp enter'a basınız..");
                    geri = Convert.ToString(Console.ReadLine());
                    if (geri == "g")
                    {
                        goto enbas;
                    }
                }
                if (islemturu == "BÖLME")
                {


                    Islem bl = new Islem();
                    Console.Write("Bölünmesini istediğiniz değeri giriniz:" + "  ");
                    double s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bölmesini istediğiniz  değeri giriniz:" + "  ");
                    double s2 = Convert.ToInt32(Console.ReadLine());
                    double sonuc = bl.Bol(s1, s2);
                    Console.WriteLine("Sonuç=" + " " + sonuc);
                    Console.WriteLine("Tekrardan İşlem seçmek için g yazıp enter'a basınız..");
                    geri = Convert.ToString(Console.ReadLine());
                    if (geri == "g")
                    {
                        goto enbas;
                    }
                }
                if (islemturu == "KALAN BULMA")
                {


                    Islem md = new Islem();
                    Console.Write("Kalanını bulmak istediğiniz değeri giriniz:" + "  ");
                    double s1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bölmek istediğiniz  değeri giriniz:" + "  ");
                    double s2 = Convert.ToInt32(Console.ReadLine());
                    double sonuc = md.Modal(s1, s2);
                    Console.WriteLine("Sonuç=" + " " + sonuc);
                    Console.WriteLine("Tekrardan İşlem seçmek için g yazıp enter'a basınız..");
                    geri = Convert.ToString(Console.ReadLine());
                    if (geri == "g")
                    {
                        goto enbas;
                    }
                    

                }
                if(islemturu!="TOPLAMA"&& islemturu != "ÇIKARMA" && islemturu != "BÖLME" && islemturu != "ÇARPMA" && islemturu != "KALAN BULMA" )
                {
                    Console.WriteLine("Seçmek istediğiniz işlemin ismini eksik veya hatalı yazdınız lütfen işlem seçmek için g yazıp enter'a basınız..");
                    geri = Convert.ToString(Console.ReadLine());
                    if (geri == "g")
                    {
                        goto enbas;
                    }


                  
                    
                }
                





            }
        }
    }
}
    

