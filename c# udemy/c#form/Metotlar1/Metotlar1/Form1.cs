using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void temizle() 
        {
            s1txt.Clear();
            s2txt.Clear();
            sonuctxt.Clear();
            islem.Text = string.Empty;



        }
        public void görünürlük() 
        {
            
            temizle();
            s1txt.Visible = true;
            s2txt.Visible = true;
            sonuctxt.Visible = true;
            deger1.Visible = true;
            deger2.Visible = true;
            sonuc.Visible = true;
            esittir.Visible = true;
            islem.Visible = true;
            geri.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = true;
            label2.Visible = true;
            label1.Visible = false;




        }


        double Toplam(double s1, double s2) 
        {

            double s3 = s1 + s2;
            return s3;
        }
        double Fark(double s1, double s2)
        {

            double s3 = s1 - s2;
            return s3;
        
        }
        double Carpım(double s1, double s2)
        {

            double s3 = s1 * s2;
            return s3;
        
        }
        double Bolum(double s1, double s2)
        {
            double s3 = s1 / s2;
            return s3;
        
        
        }
        double Mod(double s1, double s2)
        {

            double s3 = s1 % s2;
            return s3;
        
        }


        public void Enbas() 
        {
            s1txt.Visible = false;
            s2txt.Visible = false;
            sonuctxt.Visible = false;
            deger1.Visible = false;
            deger2.Visible = false;
            sonuc.Visible = false;
            esittir.Visible = false;
            islem.Visible = false;
            geri.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            label2.Visible = false;
            button6.Visible = false;




        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            görünürlük();
            islem.Text = "+";
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            görünürlük();
            islem.Text = "-";
        }    
        private void button3_Click(object sender, EventArgs e)
        {
            görünürlük();
            islem.Text = "x";
        }    
        private void button4_Click(object sender, EventArgs e)
        {
            görünürlük();
            islem.Text = "÷";
        }    
        private void button5_Click(object sender, EventArgs e)
        {
            görünürlük();
            islem.Text = "%";
        } 
        private void geri_Click(object sender, EventArgs e)
        {
            Enbas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (islem.Text=="+")
            {
                
                double s1 = Convert.ToDouble(s1txt.Text);
                double s2 = Convert.ToDouble(s2txt.Text);
                sonuctxt.Text = Toplam(s1, s2).ToString("00.00");
            }
            if (islem.Text == "-")
            {
                double s1 = Convert.ToDouble(s1txt.Text);
                double s2 = Convert.ToDouble(s2txt.Text);
                sonuctxt.Text = Fark(s1, s2).ToString("00.00");
            }
            if (islem.Text == "x")
            {
                double s1 = Convert.ToDouble(s1txt.Text);
                double s2 = Convert.ToDouble(s2txt.Text);
                sonuctxt.Text = Carpım(s1, s2).ToString("00.00");
            }
            if (islem.Text == "÷")
            {
                double s1 = Convert.ToDouble(s1txt.Text);
                double s2 = Convert.ToDouble(s2txt.Text);
                sonuctxt.Text = Bolum(s1, s2).ToString("00.00");
            }
            if (islem.Text == "%")
            {
                double s1 = Convert.ToDouble(s1txt.Text);
                double s2 = Convert.ToDouble(s2txt.Text);
                sonuctxt.Text = Mod(s1, s2).ToString("00.00");
            }
        }
    }
}
