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
    public partial class task12 : Form
    {
        public task12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fx = textBox1.Text;
            textBox2.Text = sdnf(fx);
            textBox3.Text = dnf(fx);
        }

        private string sdnf(string f)
        {
            char[] arg = { 'X', 'Y', 'Z', 'W', 'T', 'P', 'M' };
            int n = 0;
            string ans = "";
            while ((1 << n) < f.Length) n++; // quantity arguments

            for (int i = 0; i < f.Length; i++)
            {
                string BinaryCode = Convert.ToString(i, 2); // binary code int i
                if (f[i] == '1')
                {
                    if (i < f.Length / 2)
                    {
                        while (BinaryCode.Length < n) BinaryCode = "0" + BinaryCode;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (BinaryCode[j] == '0') ans += "-" + arg[j];
                        else ans += arg[j];
                    }
                    ans += " v ";
                }
            }
            if (ans[(ans.Length) - 1] == ' ') ans = ans.Substring(0, (ans.Length) - 3);

            return ans;
        }

        private string dnf(string f)
        {
            int n = 0;
            while ((1 << n) < f.Length) n++; // quantity arguments
            char[] args = { 'X', 'Y', 'Z', 'W', 'T', 'P', 'M' };
            string ans = "";
            List<string> sets = stringToList(f);
            int len = sets[0].Length;
            for(int i = 0; i < n-1; i++)
            {
                List<string> nsets = nset(sets);
                sets = nsets;
                sets = removeDuplicates(sets);
            }
            for(int i = 0; i < sets.Count; i++)
            {
                for (int j = 0; j < sets[i].Length; j++)
                {
                    if (sets[i][j] == '1') ans += args[j];
                    else if (sets[i][j] == '0')
                    {
                        ans += "-" + args[j];
                    }
                }
                if(i < (sets.Count-1)) ans += " v ";
            }
            return ans;
        }
        private List<string> stringToList(string f)
        {
            int n = 0;
            while ((1 << n) < f.Length) n++; // quantity arguments
            List<string> sets = new List<string>();
            for (int i = 0; i < f.Length; i++)
            {
                string BinaryCode = Convert.ToString(i, 2); // binary code int i
                if (i < f.Length / 2)
                {
                    while (BinaryCode.Length < n) BinaryCode = "0" + BinaryCode;
                }
                if (f[i] == '1') sets.Add(BinaryCode);
            }
            return sets;
        }
        private List<string> nset(List<string> sets)
        {
            int index = 0, count = 0;
            List<string> nsets = new List<string>();
            int[] iner = new int[sets.Count];
            for (int i = 0; i < sets.Count; i++)
            {
                for (int j = i; j < sets.Count; j++)
                {
                    if (stars(sets[i]) == stars(sets[j]))
                    {
                        for (int k = 0; k < sets[j].Length; k++)
                            if (sets[i][k] != sets[j][k] && (sets[i][k] != '*') && (sets[j][k] != '*'))
                            {
                                count++;
                                index = k;
                            }
                        if (count == 1)
                        {
                            string nset = sets[i];
                            StringBuilder sb = new StringBuilder(nset);
                            sb[index] = '*';
                            nset = sb.ToString();
                            nsets.Add(nset);
                            iner[i] = 1;
                            iner[j] = 1;
                        }
                        count = 0;
                        index = 0;
                    }
                    
                }
            }
            for(int i = 0; i < sets.Count; i++)
            {
                if (iner[i] == 0) nsets.Add(sets[i]);
            }
            return nsets;
        }
        private static List<string> removeDuplicates(List<string> list)
        {
            return new HashSet<string>(list).ToList();
        }
        private static int stars(string x)
        {
            int s = 1;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] == '*')
                {
                    s *= 10;
                    s += i;
                }
            }
            return s;
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
