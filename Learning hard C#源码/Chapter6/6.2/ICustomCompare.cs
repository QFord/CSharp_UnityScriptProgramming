using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseInterface
{
    interface ICustomCompare
    {
        // 定义比较方法,继承该接口的类都要实现该方法
         int CompareTo(object other);
    }

    // 定义类继承接口
    public class Person : ICustomCompare
    {
        // 类字段
        int age;

        // 类属性
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // 实现接口方法
        public int CompareTo(object value)
        {
            // 先判断参数对象是否为null
            if (value == null)
            {
                return 1;
            }

            // 将object类型强制转换为Person类型
            Person otherp = (Person)value;
            // 把当前对象的Age属性与需要比较对象的Age属性对比
            if (this.Age < otherp.Age)
            {
                return -1;
            }
            if (this.Age > otherp.Age)
            {
                return 1;
            }

            return 0;
        }
    }
}
