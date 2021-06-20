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
    public partial class Ex7 : Form
    {
        DateTime dateTime;
        
        TimeSpan difference ;
        string str;
        Timer timer=new Timer();
        public Ex7()
        {
            InitializeComponent();
            timer.Tick += ShowMessage;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dateTime =DateTime.Parse( maskedTextBox1.Text);
            difference = dateTime -  DateTime.Now;
            radioButton1_CheckedChanged(sender, e);
            radioButton1.Checked = true;
        }
        void ShowMessage(object sender, EventArgs e)
        {
            label3.Text = str;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            str = $"{dateTime.Year - DateTime.Now.Year} years";
            timer.Interval=500;
            timer.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            str = $"{dateTime.Year*12+dateTime.Month - DateTime.Now.Year*12- DateTime.Now.Month} months";
            timer.Interval = 500;
            timer.Start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            difference = dateTime - DateTime.Now;
            str = $"{(int)difference.TotalDays} days";
            timer.Interval = 500;
            timer.Start();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            difference = dateTime - DateTime.Now;
            str = $"{(int)difference.TotalMinutes} minutes";
            timer.Interval = 500;
            timer.Start();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            difference = dateTime - DateTime.Now;
            str = $"{(int)difference.TotalSeconds} seconds";
            timer.Interval = 100;
            timer.Start();
        }
    }
}
