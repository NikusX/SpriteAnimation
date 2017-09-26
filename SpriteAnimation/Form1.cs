using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SpriteAnimation
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White;
            bmp = new Bitmap("sprite.png");
            g = Graphics.FromImage(bmp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
