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
    public partial class task4 : Form
    {

        Point last;

        public task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fx = textBox1.Text;
            bool flag = true;
            bool[] radioBut = { radioButton3.Checked, radioButton4.Checked, radioButton5.Checked , radioButton1.Checked,
            radioButton6.Checked, radioButton2.Checked, radioButton7.Checked, radioButton8.Checked, radioButton9.Checked,
            radioButton10.Checked, radioButton11.Checked, radioButton12.Checked, radioButton13.Checked, radioButton14.Checked,
            radioButton15.Checked, radioButton16.Checked};
            for(int i = 0; i < 16; i++)
            {
                string binaryCode = Convert.ToString(i, 2);
                while (binaryCode.Length < 4) binaryCode = '0' + binaryCode;
                if (fx == binaryCode && radioBut[i])
                {
                    flag = false;
                    MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                }
            }
            if(flag) MessageBox.Show("Ответ ошибочный!", "Вы неправы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
