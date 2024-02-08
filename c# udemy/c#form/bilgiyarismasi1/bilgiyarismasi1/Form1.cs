using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarismasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button2.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
                label9.Visible = true;


            }
            else
            {

                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label10.Visible = true;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;



            label8.Text = button3.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
                label9.Visible = true;



            }
            else
            {

                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label10.Visible = true;


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;



            label8.Text = button4.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
                label9.Visible = true;



            }
            else
            {

                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label10.Visible = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            
            
            
            label8.Text = button1.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
                label9.Visible = true;



            }
            else 
            {

                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label10.Visible = true;



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            button5.Text = "Sonraki";



            soruno++;
            label4.Text = soruno.ToString();
            if (soruno == 1) 
            {

                richTextBox1.Text = "İstanbul kaç yılında fethedilmiştir?";
                button1.Text = "1071";
                button2.Text = "1453";
                button3.Text = "1553";
                button4.Text = "1653";
                label7.Text = "1453";
            }
            if (soruno == 2)
            {

                richTextBox1.Text = "Mısır'ı hangi padişah fethetmiştir?";
                button1.Text = "Kanuni Sultan Süleyman";
                button2.Text = "Fatih Sultan Mehmed";
                button3.Text = "Yavuz Sultan Selim";
                button4.Text = " I. Bayezid";
                label7.Text = "Yavuz Sultan Selim";
            }
            if (soruno == 3)
            {
                button5.Text = "Bitir";
                richTextBox1.Text = "Aşağıdakilerden hangisi Kurtuluş Savaşı cephesi değildir?";
                button1.Text = "Doğu Cephesi";
                button2.Text = "Güney Cephesi";
                button3.Text = "Batı Cephesi";
                button4.Text = "Kuzey Cephesi";
                label7.Text = "Kuzey Cephesi";
            }
            if (soruno == 4) 
            {
                button5.Text = "Sonuçlar";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru Sayısı:" +  dogru + "\n" + "\n" + "Yanlış Sayısı:" + yanlis);
            
            
            }






        }
    }
}
