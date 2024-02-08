namespace deneme21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 45;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text= sayac.ToString();
        }
    }
    }
