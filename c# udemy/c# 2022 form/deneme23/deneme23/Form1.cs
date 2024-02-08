namespace deneme23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 =Convert.ToDouble(textBox1.Text);
            double s2=Convert.ToDouble(textBox2.Text);
            double p= Convert.ToDouble(textBox3.Text);
            double ort = ((s1 + s2) / 2) + (p * 0.6);
            
            if(ort >= 50) 
            {
                
                textBox4.Text = "Tebrikler" +" " +ort.ToString("00.00")+" " + "ile geçtiniz";
            }
            else
            {
                textBox4.Text = "Malesef" +" "+ ort.ToString("00.00")+ " " + "ile kaldýnýz";
            }
        }
    }
}