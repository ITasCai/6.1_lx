using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridegroom brige = new Bridegroom();
            //实例化朋友对象（准备发请柬的名单）
            Friend f1 = new Friend("张三");
            Friend f2 = new Friend("李四");
            Friend f3 = new Friend("王五");
            Friend f4 = new Friend("狗蛋");

            //注册订阅事件（确定请柬的名单）
            //brige.EventMarray+=new MarrayDelegate（f1.SendMessage）;
            brige.EventMarray += f1.SendMessage;
            brige.EventMarray += f2.SendMessage;
            brige.EventMarray += f3.SendMessage;
            brige.EventMarray += f4.SendMessage;
            brige.EventMarray -= f4.SendMessage;

            //发布事件（发出请柬：打电话通知）
            string strMessage = "我要结婚了,哇哇哇。。。。。";
            brige.OnMarrayComing(strMessage);

            Console.ReadKey();
        }
    }
}
