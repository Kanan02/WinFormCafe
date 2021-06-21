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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1280, 720);
            this.MaximumSize = new Size(1280, 720);

        }

        private void Ex5_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int r = random.Next(0, 2);
            if (Math.Abs(e.X-button1.Location.X)<=100|| Math.Abs(e.Y - button1.Location.Y) <= 100)
            {
                if (r==0)
                {
                    
                    button1.Location=new Point(button1.Location.X + random.Next(0,40),button1.Location.Y+ random.Next(0, 40));
                }
                else
                {
                    button1.Location = new Point(button1.Location.X - random.Next(0, 40), button1.Location.Y - random.Next(0, 40));
                }
                if (button1.Location.X  > 1200 || button1.Location.Y>600 )
                {
                    button1.Location = new Point(button1.Location.X - random.Next(50, 100), button1.Location.Y - random.Next(50, 100));
                }
                if (button1.Location.X < 100 || button1.Location.Y < 100)
                {
                    button1.Location = new Point(button1.Location.X + random.Next(50, 100), button1.Location.Y + random.Next(50, 100));

                }
            }
            
        }
    }
}
