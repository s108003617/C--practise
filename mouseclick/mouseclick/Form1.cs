namespace mouseclick
{
    public partial class Form1 : Form
    {
        int times = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            times++; 
            timeslabel.Text = "�A�w�g�I�F..." + times + "�U"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0; 
            timeslabel.Text = "�A�w�g�I�F..." + times + "�U"; 
        }
    }
}