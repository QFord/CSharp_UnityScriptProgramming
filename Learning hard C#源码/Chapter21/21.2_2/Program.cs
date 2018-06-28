using System;
using System.IO;

namespace _21._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\test.txt";
            using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                string msg = "Hello World";
                StreamWriter streamWriter = new StreamWriter(fileStream); 
                Console.WriteLine("开始写入 {0} 到文件中", msg);
                streamWriter.Write(msg);
                StreamReader streamReader = new StreamReader(fileStream);
                Console.WriteLine("写入文件中的数据为：\n{0}", streamReader.ReadToEnd());
                streamWriter.Close();
                streamReader.Close();
                Console.Read();
            }
        }
    }
}
