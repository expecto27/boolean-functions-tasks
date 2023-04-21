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
            label2.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            label2.Text = "";
            Random rnd = new Random();
            int n = 0;
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите n в промежутке от 1 до 7", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (n > 7 || n < 1)
            {
                MessageBox.Show("Введите n в промежутке от 1 до 7", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label2.Text = "f(";
            
            char[] args = { 'X', 'Y', 'Z', 'W', 'T', 'P', 'M', ' ' };

            for (int i = 0; i < n; i++)
            {
                label2.Text += args[i];
                if (i < (n - 1)) label2.Text += ',';
            }
            label2.Text += ") = ";
            int k = (1 << n);
            
            for (int i = 0; i < k; i++)
            {
                label2.Text += rnd.Next(0, 2).ToString();
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
