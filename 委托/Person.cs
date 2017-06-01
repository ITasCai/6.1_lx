using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
   public class Person
    {
        public string Name { set; get; }
        public int  Age  { set; get; }

        public Person(string Name,int Age) {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
