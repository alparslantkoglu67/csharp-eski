using System;
using System.Collections.Generic;
using System.Text;

namespace c_ders_calisma
{
    class Kayit
    {
        public string isim;
        public string soyisim;
        public int yas;
        public string meslek;
        public string cinsiyet;



        public Kayit(string _isim, string _soyisim, int _yas, string _meslek, string _cinsiyet)
        {
            isim = _isim;
            soyisim = _soyisim;
            yas = _yas;
            meslek = _meslek;
            cinsiyet = _cinsiyet;
        }
        public  void Bilgigöster()
        {
            Console.WriteLine("İsim:" + "" + isim);
            Console.WriteLine("Soyisim:" + "" + soyisim);
            Console.WriteLine("Yaş:" + "" + yas);
            Console.WriteLine("Meslek:" + "" + meslek);
            Console.WriteLine("Cinsiyet:" + "" + cinsiyet);
         
        }
    }
}
