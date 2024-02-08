using System;
using System.Collections.Generic;
using System.Text;

namespace Kayıt_class_yapıcı
{
    class Kayit
    {
       
        
        public Kayit(string i,string s,int y,string m) 
        {
            
            Console.WriteLine("-------------------------------------" + "\n" + "-------------------------------------");
            Console.WriteLine("Adınız:     " + i + "\n" + "Soyadınız:  " + s + "\n" + "Yaşınız:    " + y + "\n" + "Mesleğiniz: " + m);
            Console.WriteLine("-------------------------------------" + "\n" + "-------------------------------------");
            Console.WriteLine("            Tebrikler!" + "\n" + "  Sisteme Başarıyla Kayıt Oldunuz.");
            Console.WriteLine("-------------------------------------" + "\n" + "-------------------------------------");
            Console.WriteLine("Başka bir kayıt oluşturmak için klavyeden G/g tuşuna basınız...");
            
            
            


        }

        

    }
}
