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

            int n = 0;

            while ((1 << n) < f.Length) n++; // quantity arguments

            string tDNF = textBox2.Text;

            string[] DNF = tDNF.Split('v');
            
            bool answer = true;

            bool answerTemp1 = false;

            bool answerTemp = true;
            for (int i = 0; i < f.Length; i++)
            {
                
                if (f[i] == '1')
                {
                    string BinaryCode = Convert.ToString(i, 2); // Binary code j

                    if (i < f.Length / 2) // добавление нулей в начало набора
                    {
                        while (BinaryCode.Length < n) BinaryCode = "0" + BinaryCode;
                    }

                    answerTemp1 = false;

                    for (int j = 0; j < DNF.Length; j++) // цикл по всему ДНФ 
                    {
                        answerTemp = true;
                        for (int u = 0; u < DNF[j].Length; u++) // цикл по каждому элем. ДНФ
                        {
                            if (DNF[j][u] == 'X')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[0]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[0]));
                            }
                            else if (DNF[j][u] == 'Y')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[1]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[1]));
                            }
                            else if (DNF[j][u] == 'Z')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[2]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[2]));
                            }
                            else if (DNF[j][u] == 'W')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[3]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[3]));
                            }
                            else if (DNF[j][u] == 'T')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[4]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[4]));
                            }
                            else if (DNF[j][u] == 'P')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[5]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[5]));
                            }
                            else if (DNF[j][u] == 'M')
                            {
                                if (u - 1 >= 0 && DNF[j][u - 1] == '-') answerTemp = answerTemp && (!char_to_bool(BinaryCode[6]));
                                else answerTemp = answerTemp && (char_to_bool(BinaryCode[6]));
                            }
                        }
                        answerTemp1 = answerTemp1 || answerTemp;
                        if (answerTemp1) break;
                    }
                    answer = answer && answerTemp1;
                }
            }
            if (answer) MessageBox.Show("Введенная ДНФ является верной", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Введенная ДНФ является не верной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
