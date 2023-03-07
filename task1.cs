using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boolean_functions_tasks
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void task1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "f(x) = ";
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            int k = (1 << n);
            string fx = "";
            for (int i = 0; i < k; i++)
            {
                fx += rnd.Next(0, 2).ToString();
            }
            label2.Text += fx;
        }
    }
}
