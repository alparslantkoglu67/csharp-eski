namespace deers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar = Convert.ToInt32(textBox1.Text);
            int taban = Convert.ToInt32(textBox2.Text);
            int cevre = (kenar * 2) + (taban * 2);
            int alan = kenar * taban;
            textBox3.Text = cevre.ToString();
            textBox4.Text = alan.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox5.Text);
            textBox6.Text = (sayi * sayi * sayi).ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox5.Text);
            double sayi2 = Convert.ToDouble(textBox10.Text);
            double toplam = sayi1 + sayi2;
            double fark = sayi1 - sayi2;
            double carp = sayi1 * sayi2;
            double kalan = sayi1 % sayi2;
            double bolum =Convert.ToDouble( sayi1 / sayi2);
            textBox6.Text = toplam.ToString("00.00");
            textBox7.Text = fark.ToString("0.00");
            textBox8.Text = carp.ToString("00.00");
            textBox9.Text = bolum.ToString("0.00");
            textBox11.Text = kalan.ToString();
            
        }
    }
}