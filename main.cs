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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            task1 t = new task1();
            t.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            task2 t = new task2();
            t.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            task3 t = new task3();
            t.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            task4 t = new task4();
            t.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            task5 t = new task5();
            t.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            task6 t = new task6();
            t.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            task7 t = new task7();
            t.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            task8 t = new task8();
            t.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            task9 t = new task9();
            t.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            task10 t = new task10();
            t.ShowDialog();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            task11 t = new task11();
            t.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            task12 t = new task12();
            t.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point last;
        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
