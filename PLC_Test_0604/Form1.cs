using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACTMULTILIB_K;

namespace PLC_Test_0604
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }
        
        // 연결
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0) {
                MessageBox.Show("연결되었습니다.");
                btn_connect.Enabled = false;
                //timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else MessageBox.Show("연결에 실패하였습니다.");
        }

        short value = 0;
        short sens = 0;
        bool cylBmvF = false;
        bool cylBmvB = false;
        bool cylCmvF = false;
        bool cylCmvB = false;
        bool liftA = false;
        bool liftB = false;
        // 실린더 센서
        private void timer1_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // cylinder B
            if ((sens & 0x04) != 0)
            {
                pic_cylB.ImageLocation = "images/cylinder_on.png";
                value = (short)(value | (0x01 << 2));
                
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            if((sens & 0x08) != 0)
            {
                pic_cylB.ImageLocation = "images/cylinder_off.png";
            }
            // cylinder C
            if ((sens & 0x10) != 0)
            {
                value = (short)(value | (0x01 << 4));
                plc.WriteDeviceBlock2("Y0", 1, ref value);
                pic_cylC.ImageLocation = "images/cylinder_off.png";
            }
            if ((sens & 0x20) != 0)
            {
                pic_cylC.ImageLocation = "images/cylinder_on.png";
            }
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // lift A
            if ((sens & 0x400) != 0)
            {
                pic_liftA.ImageLocation = "images/lift.png";
                value = 0x01 << 1;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            if ((sens & 0x400) == 0) pic_liftA.Image = null;
            // lift B
            if ((sens & 0x800) != 0)
            {
                pic_liftB.ImageLocation = "images/lift.png";
                value = (short)(value | (0x01 << 3));
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            if ((sens & 0x800) == 0) pic_liftA.Image = null;
        }
        // 리프트 센서
        private void timer2_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // cylinder B
            if ((sens & 0x04) != 0)
            {
                pic_cylB.ImageLocation = "images/cylinder_on.png";
                cylBmvF = true;
            }
            if ((sens & 0x08) != 0)
            {
                pic_cylB.ImageLocation = "images/cylinder_off.png";
                cylBmvF = false;
            }
            // cylinder C
            if ((sens & 0x10) != 0)
            {
                cylCmvF = true;
                pic_cylC.ImageLocation = "images/cylinder_off.png";
            }
            if ((sens & 0x20) != 0)
            {
                cylCmvF = false;
                pic_cylC.ImageLocation = "images/cylinder_on.png";
            }
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // lift A
            if ((sens & 0x400) != 0)
            {
                pic_liftA.ImageLocation = "images/lift.png";
                liftA = true;
            }
            if ((sens & 0x400) == 0)
            {
                pic_liftA.Image = null;
                liftA = false;
            }
            // lift B
            if ((sens & 0x800) != 0)
            {
                pic_liftB.ImageLocation = "images/lift.png";
                liftB = true;
            }
            if ((sens & 0x800) == 0)
            {
                pic_liftA.Image = null;
                liftB = false;
            }

            // 실린더 B 전진
            if (liftA)
            {
                value = 0x01 << 1;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            // 실린더 B 후진
            if (cylBmvF)
            {
                value = 0x01 << 2;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            // 실린더 C 전진
            if (liftB)
            {
                value = 0x01 << 3;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            // 실린더 C 후진
            if (cylCmvF)
            {
                value = 0x01 << 4;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
        }

        // 실린더 B 전진
        private void btn_mvF_Click(object sender, EventArgs e)
        {
            //plc.ReadDeviceBlock2("X0", 1, out sens);
            //value = (short)(value & 0x02);
            //value = 0x02;

            //plc.WriteDeviceBlock2("Y0", 1, ref value);
            //value = (short)(value | 0x08);
            //plc.WriteDeviceBlock2("Y0", 1, ref value);
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0xFFFB);
            value = (short)(value | 0x02);
            plc.WriteDeviceBlock2("Y0", 1, ref sens);

            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0xFFEF);
            value = (short)(value | 0x08);
            plc.WriteDeviceBlock2("Y0", 1, ref sens);
        }
        // 실린더 B 후진
        private void btn_mvB_Click(object sender, EventArgs e)
        {
            value = 0x01 << 2;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 실린더 C 전진
        private void btn_cynC_mvF_Click(object sender, EventArgs e)
        {
            value = 0x01 << 3;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 실린더 C 후진
        private void btn_cynC_mvB_Click(object sender, EventArgs e)
        {
            value = 0x01 << 4;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
    }
}
//2    3 
//0x04 0x08

//4 5

//F E D C  B A 9 8  7 6 5 4  3 2 1 0 
//0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0 
                   