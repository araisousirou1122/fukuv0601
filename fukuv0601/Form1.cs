namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = 10;
        string chr = "(>A<)";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
            label1.Text = "a-menn";　　　　　　　　　　　//ラベルが左に行くよ。
            label1.ForeColor = Color.Red;　　　　　　　　　//テキストが変わるよ。色赤になるよ
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
            label1.Text = "namuamidabutu";　　　　　　//ラベルが右に行くよ。
            label1.ForeColor = Color.Green;　　　　　//テキストが変わるよ。色緑になるよ
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            //if (
            // {
            //label1.Text = "バーロ";         //if文を作りたかった
            //label1.Text = "バーロ";
            // }
            string t = label1.Text;
            label1.Text = chr;
            chr = t;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;　　　　　　　　　　　　　　　//timer止まるよテキスト自分の名前
            label1.Text = "araisoushirou";
        }
    }
}

