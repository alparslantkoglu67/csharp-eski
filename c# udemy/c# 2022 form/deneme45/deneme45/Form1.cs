namespace deneme45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i < 11; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}