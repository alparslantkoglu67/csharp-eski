using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toplamacikarmaswitchcase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double sayi1, sayi2, toplam, carpim, bolum, fark;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            bolum = sayi1 / sayi2;
            carpim = sayi1 * sayi2;
            
            if ("+" == textBox3.Text) 
            {

                textBox4.Text = toplam.ToString();
            
            }
            if ("-" == textBox3.Text)
            {

                textBox4.Text = fark.ToString();

            }
            if ("x" == textBox3.Text)
            {

                textBox4.Text = carpim.ToString();

            }
            if ("/" == textBox3.Text)
            {

                textBox4.Text = bolum.ToString();

            }
            if (("/" != textBox3.Text) && ("x" != textBox3.Text) && ("+" != textBox3.Text) && ("-" != textBox3.Text))
            { 
                label6.Text = "Yanlış Bir İşlem Seçtiniz";
                
            }
            



















        }
    }
}
