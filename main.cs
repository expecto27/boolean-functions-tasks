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

        private void button1_Click(object sender, EventArgs e)
        {
            task1 t = new task1();
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task2 t = new task2();
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task4 t = new task4();
            t.ShowDialog();
        }
    }
}
