using System.Diagnostics.Eventing.Reader;

namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        string chr = "(>A<)";
        public Form1()
        {
            InitializeComponent();
            Form form = new Form();
            int width = form.ClientSize.Width;
            int height = form.ClientSize.Height;
            form.Show();

            Console.WriteLine($"��: {width} ����: {height}");
            //MessageBox.Show($"{label1.Right}");
            //MessageBox.Show($"{label1.Bottom}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
            label1.Text = "����Ȃ̂������ʂ����Ȃ�����Ȃ�";�@�@�@�@�@�@�@�@�@�@�@//���x�������ɍs����B
            label1.ForeColor = Color.Red;�@�@�@�@�@�@�@�@�@//�e�L�X�g���ς���B�F�ԂɂȂ��
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
            label1.Text = "�l�ƌ_�񂵂Ė��@�����ɂȂ��Ă�";�@�@�@�@�@�@//���x�����E�ɍs����B
            label1.ForeColor = Color.Green;�@�@�@�@�@//�e�L�X�g���ς���B�F�΂ɂȂ��
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = 10;
            }

            if (label1.Top < 0)
            {
                vy = 10;
            }

            if (label1.Left > 761)
            {
                vx = -10;
            }

            if (label1.Top > 433)
            {
                vy = -10;
            }

            string t = label1.Text;
            label1.Text = chr;
            chr = t;

        }

        private void label1_Click(object sender, EventArgs e)
        {




            timer1.Enabled = false;�@�@�@�@�@�@�@�@�@�@//timer�~�܂��e�L�X�g�����̖��O
            label1.Text = "���O�̕ꂿ���łׂ�";
        }
    }
}

