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
    public partial class task7 : Form
    {
        public task7()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string f = label2.Text.Substring(7);

            int n = 0;

            while ((1 << n) < f.Length) n++; // quantity arguments

            string tKNF = textBox2.Text;

            string[] KNF = { tKNF };

            if (n != 1)
            {
                KNF = tKNF.Split('*');
            }
            
            bool answer = false;
            bool answer1 = true;
            bool answerTemp1 = true;

            bool answerTemp = false;

            for (int i = 0; i < f.Length; i++)
            {
                string BinaryCode = Convert.ToString(i, 2); // Binary code j

                if (i < f.Length / 2) // добавление нулей в начало набора
                {
                    while (BinaryCode.Length < n) BinaryCode = "0" + BinaryCode;
                }
                if (f[i] == '0')
                {


                    answerTemp1 = true;

                    for (int j = 0; j < KNF.Length; j++) // цикл по всему КНФ 
                    {
                        answerTemp = false;

                        for (int u = 0; u < KNF[j].Length; u++) // цикл по каждому элем. КНФ
                        {
                            if (KNF[j][u] == 'X')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[0]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[0]));
                            }
                            else if (KNF[j][u] == 'Y')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[1]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[1]));
                            }
                            else if (KNF[j][u] == 'Z')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[2]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[2]));
                            }
                            else if (KNF[j][u] == 'W')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[3]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[3]));
                            }
                            else if (KNF[j][u] == 'T')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[4]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[4]));
                            }
                            else if (KNF[j][u] == 'P')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[5]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[5]));
                            }
                            else if (KNF[j][u] == 'M')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[6]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[6]));
                            }
                        }
                        answerTemp1 = answerTemp1 && answerTemp;
                    }
                    answer = answer || answerTemp1;
                }
                else
                {
                    answer1 = false;
                    answerTemp1 = true;
                    for (int j = 0; j < KNF.Length; j++) // цикл по всему КНФ 
                    {
                        answerTemp = false;

                        for (int u = 0; u < KNF[j].Length; u++) // цикл по каждому элем. КНФ
                        {
                            if (KNF[j][u] == 'X')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[0]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[0]));
                            }
                            else if (KNF[j][u] == 'Y')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[1]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[1]));
                            }
                            else if (KNF[j][u] == 'Z')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[2]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[2]));
                            }
                            else if (KNF[j][u] == 'W')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[3]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[3]));
                            }
                            else if (KNF[j][u] == 'T')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[4]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[4]));
                            }
                            else if (KNF[j][u] == 'P')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[5]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[5]));
                            }
                            else if (KNF[j][u] == 'M')
                            {
                                if (u - 1 >= 0 && KNF[j][u - 1] == '-') answerTemp = answerTemp || (!char_to_bool(BinaryCode[6]));
                                else answerTemp = answerTemp || (char_to_bool(BinaryCode[6]));
                            }
                            
                        }
                        answerTemp1 = answerTemp1 && answerTemp;
                    }
                    answer1 = answer1 || answerTemp1;
                }
            }
            if (!answer && answer1) MessageBox.Show("Введенная КНФ является верной", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Введенная КНФ является не верной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool char_to_bool(char x)
        {
            return !(x == '0');
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
