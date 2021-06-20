using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date=  DateTime.Parse(maskedTextBox1.Text);

            label2.Text = $"IT IS {Date(date.Day,date.Month,date.Year)}";
        }
        string Date(int D, int M, int Y)
        {
            int a, y, m, R;
            a = (14 - M) / 12;
            y = Y - a;
            m = M + 12 * a - 2;
            R = 7000 + (D + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12);
            string[] S = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            return S[R % 7];
        }
    }
}
