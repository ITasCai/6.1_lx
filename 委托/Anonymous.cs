using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    public delegate int AnonymousDelegate(int number);
    public delegate int ParamDelegate(int x,params int[]arry);
    class Anonymous
    {
        public int GetResult(int number) {
            return number + 10;
        }
    }
}
