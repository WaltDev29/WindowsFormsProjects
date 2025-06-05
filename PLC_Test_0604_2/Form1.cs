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

namespace PLC_Test_0604_2
{
    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }
        short value;
        short sens;
        // 연결
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0)
            {
                MessageBox.Show("연결되었습니다.");
                timer1.Enabled = true;
                btn_connect.Enabled = false;
            }
            else MessageBox.Show("연결 실패");
        }

        // 실린더 B
        // 전진
        private void btn_cylB_mvF_Click(object sender, EventArgs e)
        {
            cylB_mvF();
        }
        //후진
        private void btn_cylB_mvB_Click(object sender, EventArgs e)
        {
            cylB_mvB();
        }
        // 실린더 C
        // 전진
        private void btn_cylC_mvF_Click(object sender, EventArgs e)
        {
            cylC_mvF();
        }
        // 후진
        private void btn_cylC_mvB_Click(object sender, EventArgs e)
        {
            cylC_mvB();
        }

        // 리프트 A
        // 상승
        private void btn_liftA_up_Click(object sender, EventArgs e)
        {
            liftA_up();
        }
        // 하강
        private void btn_liftA_down_Click(object sender, EventArgs e)
        {
            liftA_down();
        }
        // 리프트 B (전후진 주소 반대)
        // 상승
        private void btn_liftB_up_Click(object sender, EventArgs e)
        {
            liftB_up();
        }
        // 하강
        private void btn_liftB_down_Click(object sender, EventArgs e)
        {
            liftB_down();
        }

        // 함수
        private void cylB_mvF()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0b1111111111111001);
            value = (short)(value | 0b0000000000000010);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void cylB_mvB()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0b1111111111111001);
            value = (short)(value | 0b0000000000000100);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void cylC_mvF()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0b1111111111100111);
            value = (short)(value | 0b0000000000001000);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void cylC_mvB()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0b1111111111100111);
            value = (short)(value | 0b0000000000010000);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void liftA_up()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0b1111111110011111);
            value = (short)(value | 0b0000000000100000);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void liftA_down()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0b1111111110010000);
            value = (short)(value | 0b0000000001000000);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void liftB_up()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0xFE7F);
            value = (short)(value | 0x0100);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        private void liftB_down()
        {
            plc.ReadDeviceBlock2("Y0", 1, out value);
            value = (short)(value & 0xFE7F);
            value = (short)(value | 0x0080);
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }

        bool cylB = false;
        bool cylC = false;
        bool liftA = false;
        bool liftB = false;
        bool liftA_sens = false;
        bool liftB_sens = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // 실린더 센서
            if ((sens & 0x04) != 0) cylB = true;
            if ((sens & 0x08) != 0) cylB = false;
            if ((sens & 0x20) != 0) cylC = true;    // 전후진 센서가 반대임
            if ((sens & 0x10) != 0) cylC = false;
            // 리프트 센서
            if ((sens & 0x40) != 0) liftA = true;
            if ((sens & 0x80) != 0) liftA = false;
            if ((sens & 0x100) != 0) liftB = true;
            if ((sens & 0x200) != 0) liftB = false;
            // 리프트 센서 (weight)
            if ((sens & 0x400) != 0) liftA_sens = true;
            else liftA_sens = false;
            if ((sens & 0x800) != 0) liftB_sens = true;
            else liftB_sens = false;

            // 동작 제어 (무한 루프)
            if (liftA_sens && !liftB) liftB_up();
            if (liftA_sens && (liftA && liftB)) cylB_mvF();
            if (liftB_sens && liftB)
            {
                liftA_down();
                liftB_down();
            }
            if (liftB_sens && (!liftB && !liftA)) cylC_mvF();
            if (liftA_sens && !liftA)
            {
                liftA_up();
                liftB_up();
            }
            if (!liftA_sens && !liftB_sens)
            {
                liftA_up();
                liftB_up();
            }

            if (cylB) cylB_mvB();
            if (cylC) cylC_mvB();

        }
    }
}

//XY    F E D C  B A 9 8  7 6 5 4  3 2 1 0
//  2   0 0 0 0  0 0 0 0  0 0 0 0  0 0 0 0

// 리프트 A 센서 되면 리프트 b 업
// 리프트 둘 다 올라오면 실린더 b 전진 후 후진

// 리프트 B 센서 되면 리프트 둘 다 다운
// 리프트 둘 다 내려오면 실린더 C 전진 후 후진

// 리프트 A 센서 되고 리프트가 밑에 있으면 둘 다 우리 상승