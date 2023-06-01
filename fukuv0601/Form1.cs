namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = 20;
        public Form1()
        {
            InitializeComponent();
        }


        int a = 1;

        int b = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("konnnitiha");
            MessageBox.Show($"konnitiha {textBox1.Text}kusoyarou");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Text = "konnnitiha";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // label1.Left += a;
            // label1.Top -= b;
            button4.Left += vx;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vx = 5;
            MessageBox.Show($"{vx}");
            vx = 10;
            MessageBox.Show($"{vx}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{vx}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = ("Ç®ëOÇÃê»ÇÀÇ•Ç©ÇÁ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx += 10;
            //MessageBox.Show($"{vx}");
        }
    }
}
