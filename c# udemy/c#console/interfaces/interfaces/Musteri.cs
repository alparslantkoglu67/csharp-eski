using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class Musteri
    {
        private int kilo;
        private double boy;
        
        public int Kilo 
        { 
            get 
            {
                return kilo;  
            }


            set 
            {
                kilo = value;
            
            }
        }
        public double Boy 
        {
            get 
            {
                return boy;
            } 
            set 
            {
                boy = value;
            }
            
        }
        
    }
}
