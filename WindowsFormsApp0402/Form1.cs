using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string stage = lblStage.Text;
            string input = tbInput.Text;

            switch (stage)
            {
                case "Stage 1":
                    lblStage.Text = "Stage 2";
                    break;

                case "Stage 2":
                    if (input == "3") lblStage.Text = "Stage 4";
                    else if (input == "7") lblStage.Text = "Stage 6";
                    break;

                case "Stage 4":
                    if (input == "5") lblStage.Text = "Stage 6";
                    else if (input == "8") lblStage.Text = "Stage 9";
                    break;

                case "Stage 6":
                    if (input == "10") lblStage.Text = "Stage 11";
                    break;

                case "Stage 11":
                    lblStage.Text = "Stage 9";
                    break;

                case "r":
                    lblStage.Text = "Stage 1";
                    break;

                default: break;
            }

            // if문 버전
            //if (stage == "Stage 1") lblStage.Text = "Stage 2";

            //// stage 2  go to (4 or 6)
            //else if (stage == "Stage 2")
            //{
            //    if (input == "3") lblStage.Text = "Stage 4";
            //    else if (input == "7") lblStage.Text = "Stage 6";
            //}

            //// stage 4  go to (6 or 9)
            //else if (stage == "Stage 4")
            //{
            //    if (input == "5") lblStage.Text = "Stage 6";
            //    else if (input == "8") lblStage.Text = "Stage 9";
            //}

            //// stage 6  go to (11)
            //else if (stage == "Stage 6")
            //{
            //    if (input == "10") lblStage.Text = "Stage 11";
            //}

            //// stage 11 go to (9)
            //else if (stage == "Stage 11") lblStage.Text = "Stage 9";

            //// 처음으로 
            //if (input == "r") lblStage.Text = "Stage 1";
            //    ;        }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 1; i<+1000000; i++)
            {
                num += i;
            }
                lblResult.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = { "사과", "배", "딸기" };
            string result = "";
            //for (int i = 0; i <array.Length; i++)
            //{
            //    result += array[i];
            //}
            foreach (string item in array)
            {
                result += item;
            }
            MessageBox.Show(result);
        }
    }
}