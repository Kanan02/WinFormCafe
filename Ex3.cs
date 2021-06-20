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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1280, 720);
            this.MaximumSize = new Size(1280, 720);
        }
        int recWidth = 750;
        int recHeight = 550;

        public void DrawRectangle(PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Red, 3);



            e.Graphics.DrawRectangle(blackPen, 0, 0, recWidth, recHeight);
        }

        private void Ex3_Paint(object sender, PaintEventArgs e)
        {

            DrawRectangle(e);
        }
        void ShowMessage(string str)
        {
            MessageBox.Show($"{str}", "Message");
        }
        private void Ex3_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        this.Close();
                        return;
                    }
                    if (e.Location.X < recWidth && e.Location.Y < recHeight && e.Location.X > 0 && e.Location.Y > 0)
                    {
                        ShowMessage("Mouse is inside of rectangle.");
                    }
                    else if (((e.Location.X == recWidth || e.Location.X == 0) || (e.Location.Y == recHeight || e.Location.Y == 0)))
                    {
                        ShowMessage("Mouse is on border of rectangle.");
                    }
                    else
                    {
                        ShowMessage("Mouse is out of rectangle.");
                    }


                    break;

                case MouseButtons.Right:
                    ShowMessage($"Window size: width-1280, height-720.\nRectangle size: width-{recWidth}, height-{recHeight}.");
                    break;
            }

        }



        private void Ex3_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"Mouse Position: {e.Location}";

            return;
        }
    }
}

