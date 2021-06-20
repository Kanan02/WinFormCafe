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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void EX12_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void EX3_button_Click(object sender, EventArgs e)
        {
            Ex3 ex3 = new Ex3();
            ex3.ShowDialog();
        }

        private void EX8_button_Click(object sender, EventArgs e)
        {
            BestOil ex8 = new BestOil();
            ex8.ShowDialog();
        }
    }
}
