using System;
using System.IO;
using System.Windows.Forms;

namespace Address_book

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String email = textBox2.Text;
            String phone = textBox3.Text;

            String Fulltext = (name + "\n" +email+ "\n" +phone);

            String filepath = @"C:\Users\tedba\OneDrive\Documents\Main.txt";
            try
            {
                File.WriteAllText(filepath, Fulltext);
                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
