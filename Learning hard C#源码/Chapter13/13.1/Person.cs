using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._1
{
    class Person
    {
       // 使用自动实现的属性来定义属性
       // 定义可读写属性
       public string Name{get;set;}
       // 定义只读属性
       public int Age{get;private set;}
        public Person(string name)
        {
            this.Name = name;
        }
        
    }
}
