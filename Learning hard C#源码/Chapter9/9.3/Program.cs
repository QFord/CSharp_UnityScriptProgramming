using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventEssence
{
    class Program
    {
        // 自定义委托
        public delegate void MarryHandler(string msg);

        // 使用自定义委托类型定义事件，事件名为BirthdayEvent
        public event MarryHandler MarryEvent;

        static void Main(string[] args)
        {
        }
    }
}
