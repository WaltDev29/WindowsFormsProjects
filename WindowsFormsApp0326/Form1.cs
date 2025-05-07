using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0326
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 조건문
            //if (DateTime.Now.Hour < 11)
            //{
            //    MessageBox.Show("아침입니다.");
            //}
            //else if (DateTime.Now.Hour <15)
            //{
            //    MessageBox.Show("점심입니다.");
            //}
            //else if (DateTime.Now.Hour < 22)
            //{
            //    MessageBox.Show("저녁입니다");
            //}
            //else
            //{
            //    MessageBox.Show("치킨 먹을 시간입니다.");
            //}

            // switch
            string s_input = tb_input.Text;    // <-UI로 변경
            //int input = int.Parse(s_input);
            //int remain = input % 2;
            //switch (remain)
            //{
            //    case 0:
            //        lb_result.Text = "짝수입니다.";
            //        break;
            //    case 1: 
            //        lb_result.Text = "홀수입니다.";
            //        break;
            //    default:
            //        lb_result.Text = "뭡니까?";
            //        break;
            //}

            // if문으로 변환
            //if (remain == 0)
            //{
            //    lb_result.Text = "짝수입니다.";
            //}
            //else if (remain == 1)
            //{
            //    lb_result.Text = "홀수입니다.";
            //}
            //else
            //{
            //    lb_result.Text = "뭡니까?";
            //}

            //switch (input)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        lb_result.Text = "겨울입니다.";
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        lb_result.Text = "봄입니다.";
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        lb_result.Text = "여름입니다.";
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        lb_result.Text = "가을입니다.";
            //        break;
            //    default:
            //        lb_result.Text = "1~12의 숫자를 입력해주세요.";
            //        break;
            //}

            //if (input < 0 || input > 12)
            //{
            //    lb_result.Text = "1~12의 숫자를 입력해주세요.";
            //}
            //else if (input == 12 || input < 3)
            //{
            //    lb_result.Text = "겨울입니다.";
            //}
            //else if (input < 6)
            //{
            //    lb_result.Text = "봄입니다.";
            //}
            //else if (input < 9)
            //{
            //    lb_result.Text = "여름입니다.";
            //}
            //else
            //{
            //    lb_result.Text = "가을입니다.";
            //}

            // Contains 메서드
            //if (s_input.Contains("안녕"))
            //{
            //    lb_result.Text = "안녕하세요~?";
            //}
            //else
            //{
            //    lb_result.Text = "^^";
            //}

            // for문
            //for (int i=0; i<1000; i++)
            //{
            //    Console.WriteLine((i + 1) + " : 출력");
            //}

            // 배열
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;      // write
            }

            for (int i=0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);    // read
            }
        }
    }
}
