using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class GenericDeam
    {
        public T GetResult<T>(T number) {
            T number1 = number;
            return number;
        }

    }
}
