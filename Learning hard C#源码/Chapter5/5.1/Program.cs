using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulation
{
    class Program
    {
        // 定义公共字段的存在的问题
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Learning Hard";

            // -5赋给age字段显然是不符合业务逻辑的，因为人的年龄不可能为负数
            p.Age = -5;
        }
    }

    /// <summary>
    /// 不使用封装特性来定义一个Person类，
    /// </summary>
    //public class Person
    //{
    //    // 类的内部数据
    //    // 定义了两个公有的字段
    //    public string _name;
    //    public int _age;
    //}

    /// <summary>
    /// C#中属性机制提供了对封装技术的支持
    /// </summary>
    public class Person
    {
        // 类的内部数据
        // 定义了私有的字段
        private string _name;
        private int _age;

        // 定义公有属性，外部世界通过属性来间接地访问类内部字段数据
        // 公共的Name属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
  
        // 公有的Age属性
        public int Age
        {
            get { return _age; }
            set
            {
                // 在属性定义中可以根据系统的业务逻辑添加逻辑代码
                if (value < 0 || value > 120)
                {
                    throw (new ArgumentOutOfRangeException("AgeIntPropery", value, "年龄必须在0-120之间"));
                }

                _age = value;
            }
        }
    }
}
