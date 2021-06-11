using System;
using System.Windows.Forms;

namespace Pooble_Trome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcomeBox1.Dispose();
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
