using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    // 演示带参数构造函数的使用
    static void Main(string[] args)
    {
        Point p = new Point(3,4);
    }
}
     struct Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        
}

