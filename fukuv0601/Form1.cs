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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
            label1.Text = "a-menn";�@�@�@�@�@�@�@�@�@�@�@//���x�������ɍs����B
            label1.ForeColor = Color.Red;�@�@�@�@�@�@�@�@�@//�e�L�X�g���ς���B�F�ԂɂȂ��
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
            label1.Text = "namuamidabutu";�@�@�@�@�@�@//���x�����E�ɍs����B
            label1.ForeColor = Color.Green;�@�@�@�@�@//�e�L�X�g���ς���B�F�΂ɂȂ��
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            //if (
            // {
            //label1.Text = "�o�[��";         //if������肽������
            //label1.Text = "�o�[��";
            // }
            string t = label1.Text;
            label1.Text = chr;
            chr = t;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //if(label1.Left < 0)//������
           // {
                //���������������̏�����
              // else
               // { 
                //���������s�������̏���
               // }
           // }
            
            
            
            timer1.Enabled = false;�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@//timer�~�܂��e�L�X�g�����̖��O
            label1.Text = "araisoushirou";
        }
    }
}

