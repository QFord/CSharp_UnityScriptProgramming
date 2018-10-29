using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _12._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个对象
            Friends friendcollection = new Friends();
            // Friends实现了IEnumerable所以可以使用foreach语句进行遍历
            foreach (Friend f in friendcollection)
            {
                Console.WriteLine(f.Name);
            }

            Console.Read();
        }

        // 朋友类
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

            // 实现IEnumerable<T>接口方法
            public IEnumerator GetEnumerator()
            {
                return new FriendIterator(this);
                /* // C# 2.0
                
                 for (int index = 0; index < friendarray.Length; index++)
                {
                    // 在C# 2.0中只需要使用下面语句就可以实现一个迭代器
                    yield return friendarray[index];
                }

                */
            }
        }

        //  C#1.0中实现迭代器代码——必须实现 IEnumerator接口
        public class FriendIterator : IEnumerator
        {
            private readonly Friends friends;
            private int index;
            private Friend current;
            internal FriendIterator(Friends friendcollection)
            {
                this.friends = friendcollection;
                index = 0;
            }

            // 实现IEnumerator接口中的方法
            public object Current
            {
                get
                {
                    return this.current;
                }
            }

            public bool MoveNext()
            {
                if (index + 1 > friends.Count)
                {
                    return false;
                }
                else
                {
                    this.current = friends[index];
                    index++;
                    return true;
                }
            }
            
            public void Reset()
            {
                index = 0;
            }
            
        }
    }
}
