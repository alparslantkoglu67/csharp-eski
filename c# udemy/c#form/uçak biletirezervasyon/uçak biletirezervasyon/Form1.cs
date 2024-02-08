using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uçak_biletirezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label4.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(("Rota:")+comboBox1.Text + "🡺" + comboBox2.Text + "/" + "/" + ("Tarih:")+dateTimePicker1.Text+ "/" + "/" + ("Yolcu Adı:")+textBox1.Text + "/" + "/" + ("Yolcu Soyadı:") + textBox2.Text + "/" + "/" + ("Yolcu TC'si:") + maskedTextBox1.Text + "/" + "/" + ("Yolcu Telefonu:") + maskedTextBox2.Text + "/" + "/");
        }
    }
}
