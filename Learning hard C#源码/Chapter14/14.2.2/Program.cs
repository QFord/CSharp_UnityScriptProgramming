using System;
// 引入Expression<TDelegate>类的命名空间
using System.Linq.Expressions;

namespace _14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 将lambda表达式构造成表达式树
            Expression<Func<int, int, int>> expressionTree = (a, b) => a + b;

            // 获得表达式树参数
            Console.WriteLine("参数1：{0},参数2: {1}", expressionTree.Parameters[0], expressionTree.Parameters[1]);
            // 获取表达式树的主体部分
            BinaryExpression body = (BinaryExpression)expressionTree.Body;

            // 左节点,每个节点本身就是一个表达式对象
            ParameterExpression left = (ParameterExpression)body.Left;

            // 右节点
            ParameterExpression right = (ParameterExpression)body.Right;

            Console.WriteLine("表达式树主体为：");
            Console.WriteLine(expressionTree.Body);
            Console.WriteLine("表达式树左节点为：{0}{4} 节点类型为：{1}{4}{4} 表达式树右节点为：{2}{4} 节点类型为：{3}{4}", left.Name, left.Type, right.Name, right.Type, Environment.NewLine);
            Console.Read();
        }
    }
}
