using System;
using System.Collections;

namespace _12._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Friends friendcollection = new Friends();
            foreach (Friend f in friendcollection)
            {
                Console.WriteLine(f.Name);
            }

            Console.Read();
        }
      
        //  朋友类
        public class Friend
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Friend(string name)
            {
                this.name = name;
            }
        }

        // 朋友集合
        public class Friends : IEnumerable
        {
            private Friend[] friendarray;

            public Friends()
            {
                friendarray = new Friend[]
            {
                new Friend("张三"),
                new Friend("李四"),
                new Friend("王五")
            };
            }

            // 索引器
            public Friend this[int index]
            {
                get { return friendarray[index]; }
            }

            public int Count
            {
                get { return friendarray.Length; }
            }

            // C# 2.0中简化迭代器的实现
            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < friendarray.Length; index++)
                {
                    // 在C# 2.0中只需要使用下面语句就可以实现一个迭代器
                    yield return friendarray[index];
                }
            }
        }
    }
}
