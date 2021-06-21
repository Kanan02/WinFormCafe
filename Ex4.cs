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
    public partial class Ex4 : Form
    {
        Point startPoint=new Point(0,0);
        Point endPoint= new Point(40,50);
        Rectangle rect = new Rectangle();
        System.Drawing.Graphics formGraphics;
        bool isDown = false;
        
        public Ex4()
        {
            InitializeComponent();

            label1.Text = "";
        }
        

        private void Ex4_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {
                this.Refresh();
                
                Pen drwaPen = new Pen(Color.Navy, 1);

                rect = new Rectangle(Math.Min(e.X, startPoint.X),
                                Math.Min(e.Y, startPoint.Y),
                                Math.Abs(e.X - startPoint.X),
                                Math.Abs(e.Y - startPoint.Y));

                formGraphics = this.CreateGraphics();
                formGraphics.DrawRectangle(drwaPen, rect);
            }
        }

        private void Ex4_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button==MouseButtons.Left)
            {
                isDown = true;
                
                startPoint.X = e.X;
                startPoint.Y = e.Y;
            }
        }
        void SendMessage(string str)
        {
            MessageBox.Show(str,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void Ex4_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                isDown = false;
               
                if (Math.Abs(e.X-startPoint.X)>=10 )
                {
                    
                    endPoint.X = e.X;
                    endPoint.Y = e.Y;
                    
                }
                else
                {
                    SendMessage("The minimum values of should be 10x10");
                    this.Refresh();
                }

            }

        }

        private void Ex4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right&&startPoint.X<e.X&&e.X<endPoint.X&& startPoint.Y < e.Y && e.Y < endPoint.Y)
            {
                label1.Text = $"Start Coordinates: {rect.Location}\n Area: {rect.Width * rect.Height}";
            }
        }
    }
}
