using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer= true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            int dyazi = 1;
            int dtura = 2;
            string yazi = "Yazı";
            string tura = "Tura";
            Random sayi= new Random();
            int deger=sayi.Next(1,3);
            string combo = comboBox1.Text.ToString();
            if (combo==yazi && dyazi==deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 50 TL KAZANDINIZ!";
                groupBox2.Visible= true;
            }
            if (combo == tura && dtura == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 50 TL KAZANDINIZ!";
                groupBox2.Visible = true;
            }
            else 
            {
                textBox2.Visible = true;
                textBox2.Text = "KAYBETTİNİZ!";
                textBox1.Visible = false;
                groupBox2.Visible = false;
            }

            
            








        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            int dyazi = 1;
            int dtura = 2;
            string yazi = "Yazı";
            string tura = "Tura";
            Random sayi = new Random();
            int deger = sayi.Next(1, 3);
            string combo = comboBox2.Text.ToString();
            if (combo == yazi && dyazi == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 250 TL KAZANDINIZ!";
                groupBox2.Visible = true;
            }
            if (combo == tura && dtura == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 250 TL KAZANDINIZ!";
                groupBox3.Visible = true;
            }
            else
            {
                textBox2.Visible = true;
                textBox2.Text = "KAYBETTİNİZ!";
                textBox1.Visible = false;
                groupBox3.Visible = false;
            }
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            int dyazi = 1;
            int dtura = 2;
            string yazi = "Yazı";
            string tura = "Tura";
            Random sayi = new Random();
            int deger = sayi.Next(1, 3);
            string combo = comboBox3.Text.ToString();
            if (combo == yazi && dyazi == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 1050 TL KAZANDINIZ!";
                groupBox4.Visible = true;
            }
            if (combo == tura && dtura == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 1050 TL KAZANDINIZ!";
                groupBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = true;
                textBox2.Text = "KAYBETTİNİZ!";
                textBox1.Visible = false;
                groupBox4.Visible = false;
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int dyazi = 1;
            int dtura = 2;
            string yazi = "Yazı";
            string tura = "Tura";
            Random sayi = new Random();
            int deger = sayi.Next(1, 3);
            string combo = comboBox4.Text.ToString();
            if (combo == yazi && dyazi == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 2750 TL KAZANDINIZ!";
                
                textBox2.Visible = false;
            }
            if (combo == tura && dtura == deger)
            {
                textBox1.Visible = true;
                textBox1.Text = "Tebrikler 2750 TL KAZANDINIZ!";
                
                textBox2.Visible = false;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox2.Text = "KAYBETTİNİZ!";
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible=false;
            textBox2.Visible=false;
            
            groupBox2.Visible=false;
            groupBox3.Visible=false;
            groupBox4.Visible=false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
