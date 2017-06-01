using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    public delegate int CalDelegate(ref int x,ref int y);

    class Calculate
    {
        public int Add(ref int num1,ref int num2) {
            return num1 + num2;
        }

    }
}
