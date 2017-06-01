using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
   /// <summary>
   /// 自定义委托
   /// </summary>
   /// <param name="message"></param>
    public delegate void MarrayDelegate(string message);

    /// <summary>
    /// 新郎官类，用于发布事件
    /// </summary>
    class Bridegroom
    {
        /// <summary>
        /// 定义一个事件（结婚事件）
        /// 使用自定义委托事件
        /// </summary>
        public event MarrayDelegate EventMarray;

        //发布事件
        public void OnMarrayComing(string message) {
            EventMarray(message);
        }

    }
}
