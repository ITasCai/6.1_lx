using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    /// <summary>
    /// 朋友（事件订阅者）
    /// </summary>
    class Friend
    {
        public string Name { set; get; }
        public Friend(string name)
        {
            Name = name;
        }
        /// <summary>
        /// 响应事件
        /// </summary>
        /// <param name="message"></param>

        public void SendMessage(string message) {
            Console.WriteLine(message);
            Console.WriteLine(this.Name+":莫西莫西，收到");
        }
    }
}
