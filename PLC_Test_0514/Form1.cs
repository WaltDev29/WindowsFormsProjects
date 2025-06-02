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

namespace PLC_Test_0514
{
    public partial class Form1 : Form
    {
        ActEasyIF control;  // 아직 실체화 되지 않은 상태
        public Form1()
        {
            InitializeComponent();
            control = new ActEasyIF();  // 폼이 생성될 때 생성
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            control.ActLogicalStationNumber = 0;    // 몇 번 시뮬레이터를 제어할 것인지
            if (control.Open() == 0)    // 0 : 정상적인 연결, 나머지 : 비정상
            {
                MessageBox.Show("연결되었습니다.");
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("연결에 실패했습니다.");
            }
        }

        private void btnMvForward_Click(object sender, EventArgs e)
        {
            // Y01 복동실린더 전진
            short value = 0x01 << 1;    // 0000 0010

            //// Y0 : 단동 실린더
            //// Y0 : 시작점,    1 : 한 Block,   ref : value의 주소값을 전달
            //short value = 0x01;
            control.WriteDeviceBlock2("Y0", 1, ref value);  // Block : 16 비트
        }

        private void btnMvBackward_Click(object sender, EventArgs e)
        {
            // Y02 복동실린더  후진
            short value = 0x01 << 2;    // 0000 0100
            //short value = 0x00;
            control.WriteDeviceBlock2("Y0", 1, ref value);

        }

        private void btnReadSensor_Click(object sender, EventArgs e)
        {
            // X02 : 전진 센서,  X03 : 후진 센서
            short sens = 0;
            control.ReadDeviceBlock2("X0", 1, out sens);
            if ((sens & 0x04) != 0) lblSens.Text = "전진";
            else if ((sens & 0x08) != 0) lblSens.Text = "후진";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            short sens = 0;
            control.ReadDeviceBlock2("X0", 1, out sens);
            if ((sens & 0x04) != 0) lblSens.Text = "전진";
            else if ((sens & 0x08) != 0) lblSens.Text = "후진";
            //else lblSens.Text = "이동중";
        }
    }
}

// 실시간 그래프 그래프 + 실린더 상태 이미지
// 전진이면 1, 후진이면 0