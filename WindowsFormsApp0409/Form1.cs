using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0409
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();  // 현재 디자인을 불러오는 메서드
            
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            Point point = label1.Location;
            point.Y -= 10;
            label1.Location = point;
            if ((point.X >= lblClear.Location.X - label1.Width && point.X <= lblClear.Location.X + lblClear.Width) && (point.Y >= lblClear.Location.Y - label1.Height && point.Y <= lblClear.Location.Y + lblClear.Height))
            {
                lblResult.Text = "Clear";
            }
            else if ((point.X >= lblDead.Location.X - label1.Width && point.X <= lblDead.Location.X + lblDead.Width) && (point.Y >= lblDead.Location.Y - label1.Height && point.Y <= lblDead.Location.Y + lblDead.Height))
            {
                lblResult.Text = "Dead";
            }
            else lblResult.Text = "";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Point point = label1.Location;
            point.X -= 10;
            label1.Location = point;
            if ((point.X >= lblClear.Location.X - label1.Width && point.X <= lblClear.Location.X + lblClear.Width) && (point.Y >= lblClear.Location.Y - label1.Height && point.Y <= lblClear.Location.Y + lblClear.Height))
            {
                lblResult.Text = "Clear";
            }
            else if ((point.X >= lblDead.Location.X - label1.Width && point.X <= lblDead.Location.X + lblDead.Width) && (point.Y >= lblDead.Location.Y - label1.Height && point.Y <= lblDead.Location.Y + lblDead.Height))
            {
                lblResult.Text = "Dead";
            }
            else lblResult.Text = "";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Point point = label1.Location;
            point.Y += 10;
            label1.Location = point;
            if ((point.X >= lblClear.Location.X - label1.Width && point.X <= lblClear.Location.X + lblClear.Width) && (point.Y >= lblClear.Location.Y - label1.Height && point.Y <= lblClear.Location.Y + lblClear.Height))
            {
                lblResult.Text = "Clear";
            }
            else if ((point.X >= lblDead.Location.X - label1.Width && point.X <= lblDead.Location.X + lblDead.Width) && (point.Y >= lblDead.Location.Y - label1.Height && point.Y <= lblDead.Location.Y + lblDead.Height))
            {
                lblResult.Text = "Dead";
            }
            else lblResult.Text = "";
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Point point = label1.Location;
            point.X += 10;
            label1.Location = point;
            if ((point.X >= lblClear.Location.X - label1.Width && point.X <= lblClear.Location.X + lblClear.Width) && (point.Y >= lblClear.Location.Y - label1.Height && point.Y <= lblClear.Location.Y + lblClear.Height))
            {
                lblResult.Text = "Clear";
            }
            else if ((point.X >= lblDead.Location.X - label1.Width && point.X <= lblDead.Location.X + lblDead.Width) && (point.Y >= lblDead.Location.Y - label1.Height && point.Y <= lblDead.Location.Y + lblDead.Height))
            {
                lblResult.Text = "Dead";
            }
            else lblResult.Text = "";
        }

    }
}
