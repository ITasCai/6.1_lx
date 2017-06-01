using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{

    class Greet
    {
        /// <summary>
        /// 定义一个打招呼的方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gd"></param>
        public void Greeting(string name, GreetDelegate gd) {
            gd(name);
        }
        public void Chinese(string name) {
            Console.WriteLine(name +"哈哈哈");
        }
    }
}
