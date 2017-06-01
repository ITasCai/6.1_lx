using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 委托;
namespace MyDeam
{



    class Program
    {
        public static void PrinTime()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            
        }
    }
}
