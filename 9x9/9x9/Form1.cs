namespace _9x9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = "";
            int i = 1;
            while (i <= 9)
            {
                Text += "9 x" + i + "=" + 9 * i + "\r\n";
                i++;
            }
            MessageBox.Show(Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 1; i <= 9; i++)
            {
                text += "7 x " + i + "=" + 7 * i + "\r\n";
            }
            MessageBox.Show(text);
        }
    }
}