using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tckimik_ad_soyad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "-" + "-" + textBox2.Text + "-" + "-" + comboBox1.Text + "-" + "-" + maskedTextBox1.Text + "-" + "-" + maskedTextBox2.Text);

            MessageBox.Show("Değişiklikleri Başarıyla Kaydettiniz.");

        }


    }
}
