using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satis_prjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double misir, su, cay, kola, meyvesuyu,toplam;
            
            misir = Convert.ToDouble(textBox1.Text);
            su = Convert.ToDouble(textBox2.Text);
            cay = Convert.ToDouble(textBox3.Text);
            kola = Convert.ToDouble(textBox4.Text);
            meyvesuyu = Convert.ToDouble(textBox5.Text);
            toplam = Convert.ToDouble(misir * 4) + (su * 1.50) + (cay * 2) + (kola * 3.50) + (meyvesuyu * 2.50);
            textBox7.Text = toplam.ToString("00.00");
            kasatutar = kasatutar + toplam;
            textBox6.Text = kasatutar.ToString("00.00");
            

        }
    }
}
