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
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Остаточная: ";
            string[] functionStr = textBox1.Text.Split();
            double[] function = new double[functionStr.Length];
            for (int i = 0; i < function.Length; i++)
            {
                function[i] = double.Parse(functionStr[i]);
            }
            int index = int.Parse(textBox2.Text);
            int bit = int.Parse(textBox3.Text);
            double residue = bit;
            for (int i = 0; i < function.Length/2+1; i++)
            {
                if (i != index)
                {
                    residue -= function[i];
                }
            }
            label4.Text += residue;

        }
    }
}
