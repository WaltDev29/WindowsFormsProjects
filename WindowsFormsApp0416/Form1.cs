using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp0416
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            // 이렇게 클릭 이벤트를 할당 가능
            button2.Click += new System.EventHandler(button1_Click);
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내가 만든 함수");
        }

        // object sender, EventArgs e : 전달 파라미터
        // object : 모든 C# 요소의 조상
        // EventArgs e : 
        private void button1_Click(object sender, EventArgs e)
        {
            // 캡션 영역의 텍스트도 제어가능
            DialogResult ret = MessageBox.Show("메시지 영역", "캡션", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (ret == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else if (ret == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }

            //Button btn = (Button)sender;
            //int number = int.Parse(btn.Text);
            //number = number * 10;
            //MessageBox.Show(number.ToString());

            //if (btn.Text == "button1")
            //{
            //    MessageBox.Show("1번 버튼입니다.");
            //}
            //else if (btn.Text == "button2")
            //{
            //    MessageBox.Show("2번 버튼입니다.");
            //}
        }

        int i = 0;  // 시간을 적기 위한 변수 // 멤버변수죠?
        // os가 있는 소프트웨어는 정확하게 시간을 카운트 할 수 없다.
        // 정교함이 필요한 공장에서 컴퓨터가 아닌 plc를 이용하는 이유
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            textBox1.Text = i + "초 경과";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                button3.Text = "시작";
                i = 0;
            }
            else
            {
                timer1.Enabled = true;
                button3.Text = "정지";
                textBox1.Text = "0초 경과";
            }
        }

        Form2 form2;
        private void button4_Click(object sender, EventArgs e)
        {

            form2 = new Form2();
            // ShowDialog()로 하면 안됨. 부모창의 프로세스가 멈추기 때문에
            //form2.ShowDialog();
            form2.Show();
            form2.setTextBox(textBox1.Text);



            // 새로 띄운 폼은 기존 폼의 자식요소.
            //Form1 form = new Form1();
            // 부모창에 접근 가능함. 
            //form.Show();
            // 부모창에 접근 불가
            //form.ShowDialog();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if (form2 == null) return;

            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "Up":
                    form2.goUp();
                    break;
                case "Down":
                    form2.goDown();
                    break;
                case "Left":
                    form2.goLeft();
                    break;
                case "Right":
                    form2.goRight();
                    break;
            }
        }
    }
}
