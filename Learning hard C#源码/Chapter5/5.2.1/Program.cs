using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化子类对象
            Horse horse = new Horse();
            // 在马 类的定义中并没有定义Age属性，但是下面代码却没有报错，足以证明子类继承了父类中的属性Age
            horse.Age = 2;
            Console.WriteLine("马的年龄为：{0}", horse.Age);

            // 初始化子类对象
            Sheep sheep = new Sheep();
            // 同样，在羊类中也没有定义Age属性，所以它也是继承于基类的Age属性
            sheep.Age = 1;
            Console.WriteLine("羊的年龄为：{0}", sheep.Age);
            Console.Read();
        }
    }

    /// <summary>
    /// 动物基类
    /// </summary>
    public class Animal
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                // 这里假设牛的寿命为10年
                if (value < 0 || value > 10)
                {
                    throw (new ArgumentOutOfRangeException("AgeIntPropery", value, "年龄必须在0-10之间"));
                }

                _age = value;
            }
        }
    }

    /// <summary>
    /// 马 (子类)
    /// </summary>
    public class Horse:Animal
    {
       
    }

    /// <summary>
    /// 羊 (子类)
    /// </summary>
    public class Sheep:Animal
    {
    }
}
