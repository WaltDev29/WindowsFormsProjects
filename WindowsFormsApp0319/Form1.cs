using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0319
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testBTN_Clicked(object sender, EventArgs e)
        {
            //int hour = 13;      // hour라는 4byte의 공간에 13이라는 값을 정수형으로 집어넣겠습니다.
            /*   int hour;   // hour라는 이름으로 정수형 변수를 사용하겠습니다 => 변수 선언만 하고 초기화하지 않은 상태
               hour = 10;  // hour 변수에 값 10 대입. => 변수 초기화
               Console.WriteLine((9 < hour) && (hour < 12));   // (9 < hour && hour < 12) 이것도 가능     */

            // DateTime.Now 현재 시간 가져옴
            /* Console.WriteLine((DateTime.Now.Hour) > 9 || (DateTime.Now.Hour < 12));
             Console.WriteLine((9 < DateTime.Now.Hour) && (DateTime.Now.Hour < 12));*/

            // 문자
            /*char c = (char)65;  // 65를 char로 변환 (ASCII코드에 의해서)
            c++;
            Console.WriteLine(c);*/

            // sizeof => 메모리 공간 반환
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("bool " + sizeof(bool));  // bool자료형에는 1bit만 필요하지만 cpu가 byte로 관리하므로 1byte

            // bool 자료형
            bool T = true;
            bool F = 10 < 0;
            Console.WriteLine(T);
            Console.WriteLine(F);

            // 복합 대입 연산자
            string str = "Hello";
            str += " World";
            str += "!";
            Console.WriteLine(str);
        }
    }
}
