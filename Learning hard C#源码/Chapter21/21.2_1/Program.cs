using System;
using System.IO;
using System.Text;

namespace _21._3
{
    class Program
    {
        static void Main(string[] args)
        {
           string filePath = "D:\\test.txt";
           using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate))
           {
               string msg = "Hello World";
               byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
               Console.WriteLine("开始写入 {0}到文件中", msg);
               fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
               fileStream.Seek(0, SeekOrigin.Begin);
               Console.WriteLine("写入文件中的数据为：");
               byte[] bytesFromFile = new byte[msgAsByteArray.Length];
               fileStream.Read(bytesFromFile, 0, msgAsByteArray.Length);
               Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
               Console.Read();
           }
        }
    }
}
