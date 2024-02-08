using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kayıt()
        {
            richTextBox1.Text="Adınız:" + textBox1.Text + "\n" + "Soyadınız:" + textBox2.Text + "\n" + "Yaşınız:" + textBox3.Text + "\n" + "Mesleğiniz:" + textBox4.Text;



        }
        private void button1_Click(object sender, EventArgs e)
        {
            kayıt();
        }
    }
}
