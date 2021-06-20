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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numberOfTries = 0;
            
            number = random.Next(1, 2001);
        }
        Random random = new Random();
        int numberOfTries;
        int number;
        private void ResumeButton_Click(object sender, EventArgs e)
        {
            
            string message = "My Name is Gurbanov Kanan";
            string allchars = message;
            DialogResult result = MessageBox.Show(message,"Resume",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result==DialogResult.Cancel)
            {
                Close();
            }

            else
            {
                message = "I am STEP and UFAZ Student";
                allchars += message;
                result = MessageBox.Show(message, "Resume", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                {
                    Close();
                }
                else
                {
                    message = "And I love pizza.\n";
                    allchars += message;
                    result = MessageBox.Show($"{message}Average Number of chars:{allchars.Length/3}", "Resume", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Close();
                    }
                    
                }
            }
        }

        private void TryButton_Click(object sender, EventArgs e)
        {
            numberOfTries++;
            int userNum = int.Parse(textBox1.Text);
            if (number==userNum)
            {
                DialogResult result= MessageBox.Show($"You won!\nNumber of tries:{numberOfTries}","Guess the Number",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
                if (result==DialogResult.Retry)
                {
                    numberOfTries = 0;
                    number = random.Next(1, 2001);
                    
                }
            }
            else
            {
                string mes = String.Empty;
                if (number>userNum)
                {
                    mes = "higher";
                }
                else
                {
                    mes = "lower";
                }
               
                MessageBox.Show($"Wrong!\nMy number is {mes}.", "Guess the Number", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
