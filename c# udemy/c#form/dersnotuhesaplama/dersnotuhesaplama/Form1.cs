using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersnotuhesaplama
{
    public partial class Form1 : Form
    
    {
        public Form1()
        
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            double vizesonuc, ortalamasonuc, vize1, vize2, proje;

            string ad, soyad;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            vize1 = Convert.ToDouble(maskedTextBox3.Text);
            vize2 = Convert.ToDouble(maskedTextBox4.Text);
            proje = Convert.ToDouble(maskedTextBox5.Text);
            vizesonuc = (vize1 * 40 / 100) + (vize2 * 60 / 100);
            ortalamasonuc = Convert.ToDouble((proje * 50 / 100) + (vizesonuc * 50 / 100));



            textBox3.Text = ad; 
            textBox4.Text = soyad;
            maskedTextBox1.Text = Convert.ToString(ortalamasonuc);
            



        }
    }
}
