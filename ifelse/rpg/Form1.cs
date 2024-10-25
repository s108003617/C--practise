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
                MessageBox.Show("你就是大師了吧! 我有件事想要拜託你");
            }
            else if (level == 30)
            {
                MessageBox.Show("你30等了阿! 再加把勁!");
            }
            else
            {
                MessageBox.Show("滾開! 我對你這小夥子一點興趣都沒有!");
            }
        }
    }
}