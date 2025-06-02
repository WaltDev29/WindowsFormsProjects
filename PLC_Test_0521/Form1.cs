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

namespace PLC_Test_0521
{
    public partial class lbl_autoMode : Form
    {
        ActEasyIF plc;
        public lbl_autoMode()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }


        bool isRound = false;
        bool isAuto = false;
        short sens = 0;
        short value;

        // 연결
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0)
            {
                MessageBox.Show("연결되었습니다.");
                btn_connect.Enabled = false;
                timer1.Enabled = true;
            }
            else MessageBox.Show("연결에 실패하였습니다.");
            plc.ActLogicalStationNumber = 0;
        }

        // 타이머 (자동모드, 센서감지)
        private void timer1_Tick(object sender, EventArgs e)
        {
            plc.ReadDeviceBlock2("X0", 1, out sens);
            if ((sens & 0x04) != 0)
            {
                lbl_status.Text = "전진";
                if (isRound || isAuto)
                {
                    value = 0x01 << 2;
                    plc.WriteDeviceBlock2("Y0", 1, ref value);
                    isRound = false;
                }
            }
            if ((sens & 0x08) != 0 && (sens & 0x10) != 0)
            {
                lbl_status.Text = "후진";
                if (isAuto)
                {
                    value = 0x01 << 1;
                    plc.WriteDeviceBlock2("Y0", 1, ref value);
                }
            }
        }

        // 실린더 전진
        private void btn_mvForward_Click(object sender, EventArgs e)
        {
            short value = 0x01 << 1;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 실린더 후진
        private void btn_mvBackward_Click(object sender, EventArgs e)
        {
            short value = 0x01 << 2;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
        // 실린더 1회 왕복
        private void btn_move_Click(object sender, EventArgs e)
        {
            value = 0x01 << 1;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
            isRound = true;
        }
        // 자동 모드
        private void picBox_autoMode_Click(object sender, EventArgs e)
        {
            if (!isAuto)
            {
                isAuto = true;
                picBox_autoMode.ImageLocation = "Images/btn_on.png";
            }
            else
            {
                isAuto = false;
                picBox_autoMode.ImageLocation = "Images/btn_off.png";
            } 
        }
    }
}
