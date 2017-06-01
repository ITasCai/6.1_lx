using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    /// <summary>
    /// 委托和类是一个级别的，都在命名空间下
    /// 定义一个没有参数也没有返回值的委托
    /// 定义的委托
    /// </summary>
    ///
    public delegate void MyDelegate();


    /// <summary>
    /// 定义一个有参数无返回值的委托
    /// </summary>
    /// <param name="name"></param>
    public delegate void GreetDelegate(string name);
    class Program

    {
        static void GetInfo() {
            Console.WriteLine("无参数，无返回值");

        }
        static void Main(string[] args)
        {
            //定义一个委托
            //声明一个委托变量，然后实例化一个委托对象，将方法存放到委托中

            //MyDelegate mb = new MyDelegate(GetInfo);
            ////调用委托,其实就是调用方法
            //mb();
            ////其他
            //MyDelegate md1 = GetInfo;
            //md1();
            //Console.ReadKey();

            //Greet greet = new Greet();
            //GreetDelegate g = greet.Chinese;
            //greet.Greeting("狗蛋",g);



            
            #region 带返回值的委托

           //Calculate c = new Calculate();
           // CalDelegate cd = c.Add;
           // int x = 10;int y = 55;
           // Console.WriteLine(cd(ref x,ref y));


            #endregion


            #region 匿名方法

            //AnonymousDelegate ad = delegate (int number) { return number; };
            //Console.WriteLine(ad(5));


            //ParamDelegate pd= delegate (int x,int[] array){
            //    x = x + 2;
            //    int max=array.Max();
            //    return max;
            //};
            //int result = pd(1, 2, 3, 4, 5, 6, 7, 8, 9);

            #endregion

            #region Lambda表达式

            //OtherDelegate other=delegate

         
            PersonDelegate pd = (array,p) =>
            {
                for (int i = 0; i < p.Length; i++)
                {
                    string name = p[i].Name;
                    array.Add(name);
                }
                return array.Count;
            };

            ArrayList list = new ArrayList() { "哈哈","嘎嘎"};
            Person p1 = new Person("回火", 22);
            Person p2 = new Person("单火", 12);
            int count = pd(list,p1,p2);
            Console.WriteLine(count);

            foreach (string item in list)
            {
                Console.Write(item+" ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
