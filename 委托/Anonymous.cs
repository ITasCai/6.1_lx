using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    public delegate int AnonymousDelegate(int number);
    public delegate int ParamDelegate(int y,params int[]arry);
    public delegate int OtherDelegate(int x,int y);
    public delegate int OthersDelegate(int x);
    public delegate int PersonDelegate(ArrayList list, params  Person[] person);

    public delegate T MyDelegate<T>(T value);
    public delegate U MinDelegate<T,U>(T value);

    class Anonymous
    {
        public int GetResult(int number) {
            return number + 10;
        }
    }
}
