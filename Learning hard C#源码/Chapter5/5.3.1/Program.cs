using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // 编译时错误，不能创建抽象类的实例
           // Animal animal = new Animal();
           // 可以把子类对象赋给父类类型
           // 此时存在着隐式类型转换
            Animal horse = new Horse();
            // 调用Voice方法
            horse.Voice();

            // 初始化子类对象
            Animal sheep = new Sheep();
            // 调用Voice方法，不同的子类对象调用相同方法表现出不同的行为（这里指的是叫的声音不痛）
            sheep.Voice();
            Console.Read();
        }
    }

    /// <summary>
    /// 动物基类
    /// </summary>
    public abstract class Animal
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

        /// <summary>
        /// 几乎所有动物都具有发出声音的能力（先天性的除外了）
        /// 但是对于动物的子类来说，每个子类发出的声音都是不一样的
        /// </summary>
        public virtual  void Voice()
        {
            Console.WriteLine("动物开始发出声音");
        }
    }

    /// <summary>
    /// 马 (子类)，子类应该重新基类的方法来实现自己特有的行为
    /// </summary>
    public class Horse : Animal
    {
        // 通过override关键字来重写父类方法
        public sealed override void Voice()
        {
            // 调用基类的方法
            base.Voice();
            Console.WriteLine("马发出嘶...嘶....嘶...的声音");
        }
    }

    /// <summary>
    /// 羊 (子类)
    /// </summary>
    public class Sheep : Animal
    {
        // 重写父类方法
        public override void Voice()
        {
            // 通过base语句来调用父类的方法
            base.Voice();
            Console.WriteLine("羊发出咩...咩...咩...的声音");
        }
    }

    //public class Test : Horse
    //{
    //    // 编译时错误，因为此时Voice在Horse中使用了sealed修饰定义为密封的。
    //    public override void Voice()
    //    {
    //    }
    //}
}

