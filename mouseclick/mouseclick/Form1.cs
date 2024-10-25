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
            timeslabel.Text = "你已經點了..." + times + "下"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0; 
            timeslabel.Text = "你已經點了..." + times + "下"; 
        }
    }
}