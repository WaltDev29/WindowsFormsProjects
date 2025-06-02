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

namespace PLC_Test_0528
{

    public partial class Form1 : Form
    {
        ActEasyIF plc;
        public Form1()
        {
            InitializeComponent();
            plc = new ActEasyIF();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (plc.Open() == 0)
            {
                MessageBox.Show("연결되었습니다.");
                btn_connect.Enabled = false;
                timer1.Enabled = true;
            }
            else MessageBox.Show("연결에 실패하였습니다.");
        }

        short value;
        short sens = 0;
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;
            if (chart1.Series[0].Points.Count > 20) chart1.Series[0].Points.RemoveAt(0);
            plc.ReadDeviceBlock2("X0", 1, out sens);
            // 내 방식
            // 전진 센서
            if ((sens & 0x04) != 0)
            {
                lbl_cylStatus.Text = "실린더 상태 : 전진";
                count++;
                workBindingSource.Add(new Work { count = count, time = curTime.ToString() });
                value = 0x01 << 2;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
                chart1.Series[0].Points.AddXY(curTime.ToString(), 1);
            }
            // 후진 센서
            else if ((sens & 0x08) != 0)
            {
                lbl_cylStatus.Text = "실린더 상태 : 후진";
                chart1.Series[0].Points.AddXY(curTime.ToString(), 0);
            }
            else
            {
                lbl_cylStatus.Text = "실린더 상태 : 이동중";
                chart1.Series[0].Points.AddXY(curTime.ToString(), 0.5);
            }
            // 리프트 on 센서
            if ((sens & 0x400) != 0)
            {
                lbl_liftStatus.Text = "리프트 센서 : On";
                value = 0x01 << 1;
                plc.WriteDeviceBlock2("Y0", 1, ref value);
            }
            else lbl_liftStatus.Text = "리프트 센서 : Off";

            // 교수님 방식
            //bool forward = false;
            //bool backward = false;
            //bool liftA = false;
            //if ((sens & 0x04) != 0) forward = true;
            //if ((sens & 0x08) != 0) backward = true;
            //if ((sens & 0x400) != 0) liftA = true;

            //if (backward && liftA) {
            //    value = 0x01 << 1;
            //    plc.WriteDeviceBlock2("Y0", 1, ref value);
            //}
            //else if (forward) {
            //    value = 0x01 << 2;
            //    plc.WriteDeviceBlock2("Y0", 1, ref value);
            //}

            //if (forward) lbl_cylStatus.Text = "실린더 상태 : 전진";
            //else if (backward) lbl_cylStatus.Text = "실린더 상태 : 후진";

            //if (liftA) lbl_liftStatus.Text = "리프트 센서 : On";
            //else lbl_liftStatus.Text = "리프트 센서 : Off";
        }

        private void btn_mvF_Click(object sender, EventArgs e)
        {
            value = 0x01 << 1;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }

        private void btn_mvB_Click(object sender, EventArgs e)
        {
            value = 0x01 << 2;
            plc.WriteDeviceBlock2("Y0", 1, ref value);
        }
    }
}

// 그래프
// 몇 회
// 데이터 그리드뷰로 작업 시간 리스트로 표시