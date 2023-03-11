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
        public task4()
        {
            InitializeComponent();
        }

        private void task4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fx = textBox1.Text;
            if (fx == "0000" && radioButton3.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0011" && radioButton1.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0101" && radioButton2.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0001" && radioButton4.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0010" && radioButton5.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0100" && radioButton6.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0110" && radioButton7.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "0111" && radioButton8.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1000" && radioButton9.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1001" && radioButton10.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1010" && radioButton11.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1011" && radioButton12.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1100" && radioButton13.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1011" && radioButton14.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1110" && radioButton15.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (fx == "1111" && radioButton16.Checked) MessageBox.Show("Все верно!", "Вы правы!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show("Ответ ошибочный!", "Вы неправы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
