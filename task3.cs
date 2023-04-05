using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace boolean_functions_tasks
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Функция: ";
            string f0 = textBox1.Text, f1 = textBox2.Text;
            string arg = textBox3.Text;
            int argint;
            if (Int32.TryParse(arg, out argint))
            {
                string lol = "";
                string ans = lol.PadLeft(f0.Length + f1.Length, '0');
                argint = Convert.ToInt32(Math.Abs(Int32.Parse(arg) - Math.Sqrt(ans.Length) + 1));
                int k = 0;
                for (int i = 0; i < f0.Length + f1.Length; i += (1 << argint + 1))
                {
                    for (int j = 0; j < (1 << argint); ++j)
                    {
                        ans = ans.Substring(0, i + j) + f0[k] + ans.Substring(i + j + 1);
                        ans = ans.Substring(0, i + (1 << argint) + j) + f1[k] + ans.Substring(i + (1 << argint) + j + 1);
                        k++;
                    }
                }
                label4.Text += ans;
            }
            else
            {
                MessageBox.Show("Введенный аргумент не является числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        Point last;
        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last.X;
                this.Top += e.Y - last.Y;
            }
        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            last = new Point(e.X, e.Y);
        }

    }
}
