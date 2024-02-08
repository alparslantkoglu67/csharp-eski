using System;

namespace interfaces
{
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Musteri kisi = new Musteri();
            Console.WriteLine("Vücut Kitle İndexi Hesaplama Uygulamasına Hoşgeldiniz Lütfen devam etmek için Enter'a Basın...");
            Console.ReadKey();
            Console.Write("Kilonuzu KG cinsinden giriniz:");
            kisi.Kilo = Convert.ToInt32(Console.ReadLine());
            int k = kisi.Kilo;
            Console.Write("Boyunuzu Metre cinsinden giriniz(Örnek:1,75m):");
            kisi.Boy = Convert.ToDouble(Console.ReadLine());
            double b = kisi.Boy;
           

            double a = k / (b* b);
            if (a<=18.4)
            {
                Console.WriteLine("Vücut Kitle İndexiniz:"+a.ToString("00.000") + " " + "BMI");

                Console.WriteLine("Zayıf. Kişinin boyuna oranla ağırlığının yetersiz olduğunu ifade eden bu değer ile karşılaşılması durumunda\n kişinin diyetisyen eşliğinde sağlıklı bir şekilde kilo alması önerilir.");

            }
            if (a>=18.5 && a<=24.9)
            {
                Console.WriteLine("Vücut Kitle İndexiniz:" + a.ToString("00.000") + " " + "BMI");
                Console.WriteLine("Normal. Bu değer aralığı kişinin ideal kiloda olduğunu gösterir.+\n+ Bu değere sahip olan kişilerin düzenli, dengeli ve sağlıklı beslenmeye devam etmeleri önerilir.");


            }
            if (a >= 25 && a <= 29.9)
            {

                Console.WriteLine("Vücut Kitle İndexiniz:" + a.ToString("00.000") + " " + "BMI");
                Console.WriteLine("Fazla Kilolu. Kişinin boyuna oranla kilosunun fazla olduğunu gösteren bu değer aralığında kişinin\n uygun diyet ile fazla kilolarından kurtulması önerilir.");

            }
            if (a >= 30 && a <= 34.9)
            {
                Console.WriteLine("Vücut Kitle İndexiniz:" + a.ToString("00.000") + " " + "BMI");

                Console.WriteLine("Şişman. Birinci derece obez kategorisinde değerlendiren değer aralığında,\n kişinin kilosunun sağlık açısından risk oluşturabilecek düzeyde olduğu anlaşılır.\n Bu kişilerin diyetisyen yardımıyla kilo vermesi önerilir.");

            }
            if (a >= 35 && a <= 44.9)
            {

                Console.WriteLine("Vücut Kitle İndexiniz:" + a.ToString("00.000")  +" "+"BMI");
                Console.WriteLine("Sonuçlar için enter'a basın..");
                Console.WriteLine("Şişman. İkinci derece obez olarak tanımlanan bu değerlere sahip olan kişilerde\n kalp ve damar hastalıkları bakımından risk artar.\nKişinin kilo vermek için diyetisyene başvurması önerilir.");

            }
            if (a >= 45)
            {
                Console.WriteLine("Vücut Kitle İndexiniz:" + a.ToString("00.000") + " " + "BMI");
                Console.WriteLine("Aşırı Şişman. Üçüncü derece obez kategorisinde olan bu kişilerde hastalık gelişme riski çok yüksektir.\n Hekim ve diyetisyen eşliğinde kilo verilmesi önerilir.");

            }
            Console.ReadKey();
        }
    }
}
