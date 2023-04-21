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
    public partial class task5 : Form
    {
        public task5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ff = new int[3];
            string f = label1.Text.Substring(6);
            int x = 2;
            for (int w = 0; w < ff.Length; w++)
            {
                int a = 0;
                string f10 = "";
                for (int i = a * (1 << x); i < f.Length; i += (1 << x + 1))
                {
                    for (int j = 0; j < (1 << x); ++j)
                    {
                        f10 += f[j + i];
                    }
                }
                a = 1;
                string f11 = "";
                for (int i = a * (1 << x); i < f.Length; i += (1 << x + 1))
                {
                    for (int j = 0; j < (1 << x); ++j)
                    {
                        f11 += f[j + i];
                    }
                }
                if (f10 == f11)
                {
                    ff[w] = 1;
                }
                x--;
            }
            bool t = true;
            if (checkBox1.Checked && ff[0] == 1 || !checkBox1.Checked && ff[0] == 0)
                if(checkBox2.Checked && ff[1] == 1 || !checkBox2.Checked && ff[1] == 0)
                    if(checkBox3.Checked && ff[2] == 1 || !checkBox3.Checked && ff[2] == 0)
                    {
                        MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        t = false;
                        label1.Text = "f(x) =";
                        Random rnd = new Random();
                        string fx = "";
                        for (int i = 0; i < 8; i++)
                        {
                            fx += rnd.Next(0, 2).ToString();
                        }
                        label1.Text += fx;
                    }
            if(t) MessageBox.Show("Ошибка!", "Вы не правы!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void task5_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string fx = "";
            for (int i = 0; i < 8; i++)
            {
                fx += rnd.Next(0, 2).ToString();
            }
            label1.Text += fx;
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
