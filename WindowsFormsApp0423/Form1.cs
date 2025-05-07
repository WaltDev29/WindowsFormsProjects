using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0423
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // HTML : <a href="">
            System.Diagnostics.Process.Start("https://www.naver.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> text = new List<string>();
            string msg = "";

            // foreach
            foreach (var item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton checkBox = item as RadioButton; // 밑 문장이랑 같은 것
                                                                //CheckBox checkBox = (CheckBox)item;

                    // 이런 방식
                    if (checkBox.Checked)
                    {
                        msg += checkBox.Text + ",";
                    }

                    // 리스트를 활용한 방식
                    //if (checkBox.Checked)
                    //{
                    //    text.Add(checkBox.Text);                        
                    //}
                }
            }
            //
            msg = msg.Remove(msg.Length - 1);
            //if (msg[msg.Length - 1] == ',')
            //{
            //    msg[msg.Length - 1] = "";
            //}

            // 리스트를 활용한 경우
            //msg = string.Join(",", text);

            // 하나씩 조건 검사
            //if (checkBox1.Checked == true)
            //{
            //    msg = checkBox1.Text + ",";
            //}
            //if (checkBox2.Checked == true)
            //{
            //    msg += checkBox2.Text + ",";
            //}
            //if (checkBox3.Checked == true)
            //{
            //    msg += checkBox3.Text;
            //}

            if (msg == "") msg = "체크된 사항 없음";
            // 이런 방식. 하지만 위에가 훨씬 편함
            //if (!checkBox1.Checked
            //    && !checkBox2.Checked
            //    && !checkBox3.Checked) msg = "체크된 사항 없음";
            MessageBox.Show(msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productBindingSource.Add(new Product() { Name = "고구마", Price = 500 });
            productBindingSource.Add(new Product() { Name = "감자", Price = 600 });
            productBindingSource.Add(new Product() { Name = "토마토", Price = 1000 });
            //comboBox1.Items.Add("옥수수");
            //comboBox1.Items.Add("수박");
            //comboBox1.Items.AddRange(new string[] { "옥수수", "수박" });
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            //comboBox1.Items.Clear();    // 요소 전부 제거
            // 하나씩 추가            
            listBox1.Items.Add(comboBox1.Text);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 
            int price = (int)comboBox1.SelectedValue;
            string name = (string)comboBox1.Text;
            MessageBox.Show(name + " : " + price + "원");
            // 객체 사용
            //Product myProdcut = comboBox1.SelectedItem as Product;
            //string name = myProdcut.Name;
            //int price = myProdcut.Price;
            //myProdcut.Show();
        }
    }
}

// 