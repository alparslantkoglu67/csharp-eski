using System;
using System.Collections.Generic;
using System.Text;

namespace kayıt_class
{
    class Kayit
    {
        public string Isim;
        public string Soyisim;
        public int Yas;
        public string Meslek;

        public void liste() 
        {
            string i = Isim;
            string s = Soyisim;
            int y = Yas;
            string m = Meslek;
            Console.WriteLine("Adınız:    " + " " + i + "\n" + "Soyadınız: " + " " + s + "\n" + "Yaşınız:   " + " " + y + "\n" + "Mesleğiniz:" + " " + m);
            Console.WriteLine("Tebrikler!" + "\n" + "Sisteme Başarıyla Kayıt Oldunuz..");
        
        
        
        }
        

        














    }
}
