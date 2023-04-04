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
    public partial class task10 : Form
    {
        public task10()
        {
            InitializeComponent();
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

        private bool isT0(string f)
        {
            return (f[0] == '0');
        }
        private bool isT1(string f)
        {
            return (f[f.Length-1] == '1');
        }

        private bool isS(string f)
        {
            for(int i = 0; i < f.Length/2; i++)
            {
                if (f[i] == f[f.Length - i - 1]) return false;
            }
            return true;
        }

        private bool isM(string f)
        {
            for(int i = 1; i < f.Length; i+=2)
            {
                if (charToInt(f[i]) < charToInt(f[i-1])) return false;
            }
            return true;
        }
        private int charToInt(char ch)
        {
            if (ch == '1') return 1;
            return 0;
        }
        private bool check(string f)
        {
            if (checkBox1.Checked != isT0(f)) return false;
            else if (checkBox2.Checked != isT1(f)) return false;
            else if (checkBox3.Checked != isS(f)) return false;
            else if (checkBox4.Checked != isM(f)) return false;
            //else if (checkBox5.Checked != isL(f)) return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string f = label2.Text.Substring(7);
            if(check(f)) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show("Ответ ошибочный!", "Вы неправы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
