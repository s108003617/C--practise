namespace wow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "§A¦n";
            string str2 = " «¢«¢ ";
            int number = 54321;
            string str3 = str + str2 + number;
            str += 123;
            MessageBox.Show(str);
        }
    }
}