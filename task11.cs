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
    public partial class task11 : Form
    {
        private bool[] all;
        public task11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            fx.Text = "f(x) = ";
            gx.Text = "g(x) = ";
            px.Text = "p(x) = ";
            qx.Text = "q(x) = ";
            hx.Text = "h(x) = ";

            Random rnd = new Random();

            if (n > 7 || n < 1)
            {
                MessageBox.Show("Введите n в промежутке от 1 до 7", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int k = (1 << n);
            this.all = new bool[k];
            //this.all = new bool[k];

            Label[] fs = { fx, gx, px, qx, hx };
            
            for(int j = 0; j < 5; j++)
            { 
                for (int i = 0; i < k; i++)
                {
                    fs[j].Text += rnd.Next(0, 2).ToString();
                }
            }
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Label[] fs = { fx, gx, px, qx, hx };
            bool T0 = true, T1 = true, S = true, M = true, L = true;
            for(int i = 0; i < 5; i++)
            {
                if (!isT0(fs[i].Text.Substring(7))) T0 = false;
                if (!isT0(fs[i].Text.Substring(7))) T1 = false;
                if (!isS(fs[i].Text.Substring(7))) S = false;
                if (!isM(fs[i].Text.Substring(7))) M = false;
                if (!isL(fs[i].Text.Substring(7))) L = false;
            }
            if (radioButton1.Checked)
            {
                if (!T0 && !T1 && !S && !M && !L)
                {
                    MessageBox.Show("Все верно!", "Вы правы, набор полный!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Ответ ошибочный!", "Вы не правы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool g = true;
                if (checkBox1.Checked != T0 || checkBox2.Checked != T1 || checkBox3.Checked != S || checkBox4.Checked != M || checkBox5.Checked != L) g = false;
                if(g) MessageBox.Show("Все верно!", "Вы правый!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Ответ ошибочный!", "Вы не правы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isT0(string f)
        {
            return (f[0] == '0');
        }
        private bool isT1(string f)
        {
            return (f[f.Length - 1] == '1');
        }

        private bool isS(string f)
        {
            for (int i = 0; i < f.Length / 2; i++)
            {
                if (f[i] == f[f.Length - i - 1]) return false;
            }
            return true;
        }

        private bool isM(string f)
        {
            for (int i = 1; i < f.Length; i += 2)
            {
                if (charToInt(f[i]) < charToInt(f[i - 1])) return false;
            }
            return true;
        }



        private bool isL(string f)
        {
            if (f.Length == 2) return true;
            bool[] func = stringToBool(f);
            bool[] func1 = pascal(func);
            all[0] = func1[0];
            for (int i = 0; i < all.Length; i++)
            {
                string BinaryCode = Convert.ToString(i, 2);
                if (all[i] && flen(BinaryCode) > 1) return false;
            }
            return true;
        }

        private int flen(string f)
        {
            int c = 0;
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] == '1') c++;
            }
            return c;

        }
        private bool[] pascal(bool[] f)
        {
            bool[] f1 = new bool[f.Length - 1];
            for (int i = 1; i < f.Length; i++)
            {
                f1[i - 1] = f[i] ^ f[i - 1];
            }
            if (f.Length == 1)
            {
                all[all.Length - 1] = f[0];
                return f;
            }
            all[all.Length - f1.Length] = f1[0];
            return pascal(f1);
        }
        private bool[] stringToBool(string f)
        {
            bool[] func = new bool[f.Length];
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] == '0') func[i] = false;
                else func[i] = true;
            }
            return func;
        }

        private int charToInt(char ch)
        {
            if (ch == '1') return 1;
            else return 0;
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
