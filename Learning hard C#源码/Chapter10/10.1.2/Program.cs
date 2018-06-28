using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedType
{
    class Program
    {
        static void Main(string[] args)
        {         
            NestedRefTypeInValue valuetype = new NestedRefTypeInValue(new TestClass());
        }
    }
    // 引用类型嵌套定义值类型的情况
    public class NestedValueTypeInRef
    {
        // valuetype作为引用类型一部分分配在托管堆上
        private int valuetype = 3;
      
        public void method()
        {
            // c分配在线程堆栈上
            char c = 'c';
        }
    }

    // 类定义
    public class TestClass
    {
        public int x;
        public int y;
    }

    // 值类型嵌套定义引用类型的情况
    public struct NestedRefTypeInValue
    {
        // 结构体字段，注意:结构体重字段不能初始化
        private TestClass classinValuetype;

        // 结构体中构造函数，注意，结构体中不能定义无参的构造函数
        public NestedRefTypeInValue(TestClass t)
        {
            classinValuetype.x = 3;
            classinValuetype.y = 5;
            classinValuetype = t;
        }
    }
}
