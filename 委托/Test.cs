using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
  public  class Test
    {
        public delegate void GetDate();
        public void DoSomething(GetDate d )
        {
            Console.WriteLine("第一步操作");
            Console.WriteLine("第二步操作");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine("第四步操作");
            Console.WriteLine("第五步操作");
        }
    }
}
