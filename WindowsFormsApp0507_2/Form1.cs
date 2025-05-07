using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0507_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 50) chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), 1);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 50) chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), 0);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }
        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            double randNum = rand.NextDouble() * 10.0;
            if (chart1.Series[0].Points.Count > 50) chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(DateTime.Now.ToString(), randNum);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
