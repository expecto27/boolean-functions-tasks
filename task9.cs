﻿using System;
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
    public partial class task9 : Form
    {
        public task9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            char[] arg = { 'X', 'Y', 'Z', 'W', 'T', 'P', 'M' };
            int n = 0;
            string ans = "";
            while ((1 << n) < f.Length) n++; // quantity arguments

            for (int i = 0; i < f.Length; i++)
            {
                string BinaryCode = Convert.ToString(i, 2); // binary code int i
                if (f[i] == '0')
                {
                    ans += "(";
                    if (i < f.Length / 2)
                    {
                        while (BinaryCode.Length < n) BinaryCode = "0" + BinaryCode;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (BinaryCode[j] == '1') ans += "-" + arg[j];
                        else ans += arg[j];
                        ans += "v";

                    }
                    if (ans[(ans.Length) - 1] == 'v') ans = ans.Substring(0, (ans.Length) - 1);
                    ans += ")";

                }
            }

            textBox2.Text = ans; // answer
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
