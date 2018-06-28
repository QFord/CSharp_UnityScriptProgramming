using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Instantiate 
{
    /// <summary>
    /// 类的实例化演示
    /// 类必须只有实例构造函数才能被实例化
    /// 并且静态类不能有实例构造函数
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化两个类对象
            // 对象张三,男
            Person person1 = new Person("张三", true);
            // 对象李四，女，此时person1和person2都是类的实例对象
            Person person2 = new Person("李四", false);
        }
    }

    class Person
    {
        // 私有字段name代表人的名字
        private string name="123";
        // 私有字段代表性别
        // true代表男，false代表女
        private bool sex;
        // 公有属性
        public string Name
        {
            get;
            set;
        }
        public bool Sex
        {
            get;
            set;
        }

        // 带两个参数的实例构造函数
        public Person(string name, bool sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }
}
