namespace rpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level = 10;
            if (level > 30)
            {
                MessageBox.Show("�A�N�O�j�v�F�a! �ڦ���ƷQ�n���U�A");
            }
            else if (level == 30)
            {
                MessageBox.Show("�A30���F��! �A�[��l!");
            }
            else
            {
                MessageBox.Show("�u�}! �ڹ�A�o�p�٤l�@�I���쳣�S��!");
            }
        }
    }
}