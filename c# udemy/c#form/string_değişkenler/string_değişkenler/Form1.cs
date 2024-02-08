using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, yas, cinsiyet, meslek;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            yas = maskedTextBox1.Text;
            cinsiyet = comboBox1.Text;
            meslek = textBox3.Text;

            listBox1.Items.Add(ad + "//" + "//" + soyad + "//" + "//" + yas + "//" + "//" + cinsiyet + "//" + "//" + meslek);

            
        }

        
    }
}
