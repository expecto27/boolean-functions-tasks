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
            string f = textBox1.Text;
            int x1 = int.Parse(textBox2.Text); // variable number
            int x = Convert.ToInt32(Math.Abs(x1 - Math.Sqrt(f.Length)));
            int a = int.Parse(textBox3.Text); // 0 or 1
            for (int i = a * (1 << x); i < f.Length; i += (1 << x + 1))
            {
                for (int j = 0; j < (1 << x); ++j)
                {
                    label4.Text += f[j + i];
                }
            }
            
        }
    }
}
