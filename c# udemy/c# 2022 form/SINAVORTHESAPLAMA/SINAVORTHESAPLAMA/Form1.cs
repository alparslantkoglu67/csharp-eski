namespace SINAVORTHESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            string mesaj;
            string ad = textBox1.Text.ToString();
            string soyad = textBox2.Text.ToString();
            double s1 = Convert.ToDouble(textBox3.Text);
            double s2 = Convert.ToDouble(textBox4.Text);
            double p = Convert.ToDouble(textBox5.Text);
            double ort = (s1 * (0.4)) + (s2 * (0.4)) + (p * (0.2));
            listBox1.Items.Add(ad);
            listBox1.Items.Add(soyad);

            if (ort >= 50) 
            { 
            mesaj=ort+" 'ÝLE GEÇTÝNÝZ TEBRÝKLER";
            }
            else
            {
                mesaj = ort + "' ÝLE KALDINIZ";
            }
            listBox1.Items.Add(mesaj);

        }
    }
}