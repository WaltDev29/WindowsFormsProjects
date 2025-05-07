using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0416
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setTextBox(string text)
        {
            textBox1.Text = text;
        }

        public void goUp()
        {
            int Y = label1.Location.Y;
            Y -= 2;
            label1.Location = new Point(label1.Location.X, Y);
        }

        public void goDown()
        {
            int Y = label1.Location.Y;
            Y += 2;
            label1.Location = new Point(label1.Location.X, Y);
        }

        public void goLeft()
        {
            int X = label1.Location.X;
            X -= 2;
            label1.Location = new Point(X, label1.Location.Y);
        }

        public void goRight()
        {
            int X = label1.Location.X;
            X += 2;
            label1.Location = new Point(X, label1.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int X = label2.Location.X;
            X -= 3;
            int Y = label2.Location.Y;
            

            if (X < -20)
            {
                X = 500;
                Random rand = new Random();
                Y = rand.Next(10, 300);
            }
            label2.Location = new Point(X, Y);
        }
    }
}
