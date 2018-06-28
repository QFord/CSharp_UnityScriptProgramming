using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda表达式的演变过程
            // 下面是C# 1中创建委托实例的代码
            Func<string, int> delegatetest1 = new Func<string, int>(Callbackmethod);

            //                                  ↓
            // C# 2中用匿名方法来创建委托实例，此时就不需要额外定义回调方法Callbackmethod
            Func<string, int> delegatetest2 = delegate(string text)
            {
                return text.Length;
            };
            //                      ↓
            // C# 3中使用Lambda表达式来创建委托实例
            Func<string, int> delegatetest3 = (string text) => text.Length;

            //                                  ↓
            // 可以省略参数类型string,把上面代码再简化为：
            Func<string, int> delegatetest4 = (text) => text.Length;

            //                                  ↓
            // 此时可以把圆括号也省略,简化为：
            Func<string, int> delegatetest = text => text.Length;

            // 调用委托
            Console.WriteLine("使用Lambda表达式返回字符串的长度为： " + delegatetest("learning hard"));

            //无参Lambda表达式"
            Action showAction = () => Console.WriteLine("无参Lambda表达式");
            showAction();

            //Lambda表达式在LINQ中的应用
            Func<Student, bool> isStudentTeenAger = s=> s.Age > 12 && s.Age < 20;
            Student st1 = new Student("QFord",35);
            Student st2 = new Student("zz", 14);
            Student st3 = new Student("xx", 17);
            //Console.WriteLine("{0} 是否青少年：{1}",st1.Name, isStudentTeenAger(st1));
            //对象初始化器
            IList<Student> studentList = new List<Student>() { st1,st2,st3};
            var teenStudents = studentList.Where(isStudentTeenAger).ToList<Student>();
            foreach(var item in teenStudents)
            {
                Console.WriteLine("{0} 是否青少年：{1}", item.Name, isStudentTeenAger(item));
            }

            //LINQ查询
            teenStudents = (from s in studentList
                           where isStudentTeenAger(s)
                           select s).ToList<Student>();



            Console.Read();
        }

        /// <summary>
        /// 输出字符串的长度
        /// </summary>
        private static int Callbackmethod(string text)
        {
            return text.Length;
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
