using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._1
{
    public struct TestPerson
    {
       // 使用自动实现的属性来定义属性
       // 定义可读写属性
       public string Name{get;set;}
       // 定义只读属性
       public int Age{get;private set;}
       
       // 结构体中构造函数不显式调用无参构造函数this()时会出现编译错误
       public TestPerson(string name)
            :this()
        {
            this.Name = name;
        }
    }
}
