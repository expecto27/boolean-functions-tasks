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
    public partial class task6 : Form
    {
        public task6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fx = label2.Text.Substring(7);
            label2.Text = fx;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            label2.Text = "f(x) = ";
            Random rnd = new Random();

            if (n > 7 || n < 1)
            {
                MessageBox.Show("Введите n в промежутке от 1 до 7", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
