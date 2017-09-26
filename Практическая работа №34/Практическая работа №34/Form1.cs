using System;
using System.Drawing;
using System.Windows.Forms;

namespace Практическая_работа__34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Bitmap bmp_2;
        int x, y,x1,y1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //checkBox1.Checked = true;
            bmp = new Bitmap("plane_1.png");
            bmp_2 = new Bitmap("plane_2.png");
                x = this.Width / 2;
              y = this.Height / 2;

            x1 = this.Width / 2;
            y1= this.Height / 2-70;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: if (y - 10 > 0) y -= 10; break;
                case Keys.Down: if (y + 10 < (this.ClientSize.Height - 40)) y += 10; break;
                case Keys.Left: if (x - 10 > 0) x -= 10; break;
                case Keys.Right: if (x + 10 < this.Width - 20) x += 10; else { x = -40; } break;

                case Keys.W: if (y - 10 > 0) y -= 10; break;
                case Keys.S: if (y + 10 < (this.ClientSize.Height - 40)) y += 10; break;
                case Keys.A: if (x - 10 > 0) x -= 10; break;
                case Keys.D: if (x + 10 < this.Width - 20) x += 10; else { x = -40; } break;

            }

            this.Invalidate();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==false)
            {
                timer1.Enabled = false;
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                this.Invalidate();
            }
            else
            {
                timer1.Enabled = true;
                checkBox1.Enabled=true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: if (y - 10 > 0) y -= 10; break;
                case Keys.Down: if (y + 10 < (this.ClientSize.Height - 40)) y += 10; break;
                case Keys.Left: if (x - 10 > 0) x -= 10; break;
                case Keys.Right: if (x + 10 < this.Width - 20) x += 10; else { x = -40; } break;

                case Keys.W: if (y - 10 > 0) y -= 10; break;
                case Keys.S: if (y + 10 < (this.ClientSize.Height - 40)) y += 10; break;
                case Keys.A: if (x - 10 > 0) x -= 10; break;
                case Keys.D: if (x + 10 < this.Width - 20) x += 10; else { x = -40; } break;
            }
            
                          this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + 10 < this.Width - 20) x += 10; else { x = -40; }

            if ((x1-10) > -40)  x1-= 20; else { x1 = this.Width-5; }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp,new Point(x,y));
            if(checkBox1.Checked==true)
                e.Graphics.DrawImage(bmp_2, new Point(x1, y1));
        }
    }
}
