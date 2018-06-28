using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);

            printActionDel(getRandomNumber());

            Console.Read();
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        //匿名方法
        static Func<int> getRandomNumber = delegate ()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        };
        //lambda表达式
        Func<int> getRandomNumber1 = () => new Random().Next(1, 100);
        Func<int, int, int> Sum = (x, y) => x + y;
    }
}
