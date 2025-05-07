using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0423
{
    class Product
    {
        // string 타입 Name이라는 변수
        // get; set; => 외부에서 get도 가능 set도 가능하다.
        public string Name { get; set; }
        public int Price { get; set; }
        public void Show()
        {
            MessageBox.Show(this.Name + " : " + this.Price + "원");
        }
    }
}
