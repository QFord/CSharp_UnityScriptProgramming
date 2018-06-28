using System;
using System.IO;

namespace _21._1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            StreamWriter writer = null;
            string path = "D:\\test.txt";
            if (!File.Exists(path))
            {
                fs = File.Create(path);
                Console.WriteLine("新建一个文件：{0}", path);
            }
            else
            {
                fs = File.Open(path, FileMode.Open);
                Console.WriteLine("文件已存在，直接打开");
            }
            writer = new StreamWriter(fs);
            writer.WriteLine("测试文本");
            Console.WriteLine("向文件写入文本数据");
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("关闭数据流");
        }
    }
}
