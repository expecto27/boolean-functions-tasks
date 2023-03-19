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
    public partial class task6 : Form
    {
        public task6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = label2.Text.Substring(7);
            char[] arg = { 'X', 'Y', 'Z', 'W', 'T', 'P', 'M' };
            int n = 0;
            string tmp = textBox2.Text;
            int count = 0;

            for (int i = 0; i < tmp.Length; i++) if (tmp[i] == 'v') count++;

            string[] DNF = new string[++count];
            int temp = 0;
            for (int i = 0; i < count; i++) // writing every member of DNF to tmp[]
            {
                if (temp > 0) temp++;
                for(int j = temp; j < tmp.Length; j++)
                {
                    if (tmp[j] == 'v'){
                        temp = j;
                        break;
                    } else {
                        DNF[i] += tmp[j];
                    }
                }
            }
            bool flag = true;
            while ((1 << n) < f.Length) n++; // quantity arguments
            temp = 0;
            bool answer1 = false;
            for(int i = 0; i < count; i++)
            {
                bool answer2 = true;
                
                for (int j = temp; j < tmp.Length; j++)
                {
                    string BinaryCode = Convert.ToString(i, 2); // binary code int i
                    if (i < f.Length / 2)
                    {
                        while (BinaryCode.Length < n) BinaryCode = "0" + BinaryCode;
                    }
                    if (tmp[j] == ' ') j++;
                    if (tmp[j] == '-')
                    {
                        string BinaryCode1 = "";
                        for (int y = 0; y < BinaryCode.Length; y++)
                        {
                            if (BinaryCode[y] == '0') BinaryCode1 += '1' + BinaryCode1;
                            else BinaryCode1 += '0' + BinaryCode1;
                        }
                        BinaryCode = BinaryCode1;
                    }

                    else if (tmp[j] == 'X')
                    {
                        answer2 &= char_to_bool(BinaryCode[0]);
                    }
                    else if (tmp[j] == 'Y')
                    {
                        answer2 &= char_to_bool(BinaryCode[1]);
                    }
                    else if (tmp[j] == 'Z')
                    {
                        answer2 &= char_to_bool(BinaryCode[2]);
                    }
                    else if (tmp[j] == 'W')
                    {
                        answer2 &= char_to_bool(BinaryCode[3]);
                    }
                    else if (tmp[j] == 'T')
                    {
                        answer2 &= char_to_bool(BinaryCode[4]);
                    }
                    else if (tmp[j] == 'P')
                    {
                        answer2 &= char_to_bool(BinaryCode[5]);
                    }
                    else if (tmp[j] == 'M')
                    {
                        answer2 &= char_to_bool(BinaryCode[6]);
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("ДНФ введена некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                answer1 = answer1 || answer2;

            }
            if(answer1) MessageBox.Show("ДНФ введена верно", "Вы правы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(flag) MessageBox.Show("ДНФ введена корректно, но неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool char_to_bool(char x)
        {
            if (x == '0') return false;
            return true;
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
    }
}
