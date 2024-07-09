namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            String password = textBox2.Text;
            MessageBox.Show("Your username is " + text + "\nYour password is "+ password);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
