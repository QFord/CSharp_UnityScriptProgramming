using System;
// 引入Expression<TDelegate>类的命名空间
using System.Linq.Expressions;

namespace _14._6
{
    class Program
    {
        // 构造a+b表达式树结构
        static void Main(string[] args)
        {
            // 表达式的参数
            ParameterExpression a = Expression.Parameter(typeof(int), "a");
            ParameterExpression b = Expression.Parameter(typeof(int), "b");
            
            // 表达式树主体部分
            BinaryExpression be = Expression.Add(a, b);

            // 构造表达式树
            Expression<Func<int, int, int>> expressionTree = Expression.Lambda<Func<int, int, int>>(be, a, b);

            // 分析树结构，获取表达式树的主体部分
            BinaryExpression body = (BinaryExpression)expressionTree.Body;

            // 左节点,每个节点本身就是一个表达式对象
            ParameterExpression left = (ParameterExpression)body.Left;

            // 右节点
            ParameterExpression right = (ParameterExpression)body.Right;

            // 输出表达式树结构
            Console.WriteLine("表达式树结构为："+expressionTree);
            // 输出
            Console.WriteLine("表达式树主体为：");
            Console.WriteLine(expressionTree.Body);
            Console.WriteLine("表达式树左节点为：{0}{4} 节点类型为：{1}{4}{4} 表达式树右节点为：{2}{4} 节点类型为：{3}{4}", left.Name, left.Type, right.Name, right.Type, Environment.NewLine);
            
            Console.Read();
        }
    }
}
