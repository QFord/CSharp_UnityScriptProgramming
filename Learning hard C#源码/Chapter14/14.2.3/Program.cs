using System;
// 引入Expression<TDelegate>类的命名空间
using System.Linq.Expressions;

namespace _14._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 将lambda表达式构造成表达式树
            Expression<Func<int, int, int>> expressionTree = (a, b) => a + b;
            // 通过调用Compile方法来生成Lambda表达式的委托
            Func<int,int,int> delinstance =expressionTree.Compile();
            // 调用委托实例获得结果
            int result = delinstance(2, 3);
            Console.WriteLine("2和3的和为：" + result);
            Console.Read();
        }
    }
}
