using System;
using System.IO;
using System.Text;

namespace _21._5
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;
            string filePath = "D:\\test.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                fileStream = File.Create(filePath);
                Console.WriteLine("新建文件：{0}", filePath);
                fileStream.Close();
            }
            else
            {
                Console.WriteLine("文件： {0}已存在,直接打开", filePath);
            }
            fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.None, 4096, true);
                      
            Console.WriteLine("开启异步操作: {0}", fileStream.IsAsync);
            string msg = "HelloWorld";
            byte[] buffer= Encoding.UTF8.GetBytes(msg);
            // 开始异步操作
            IAsyncResult asyncResult = fileStream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(EndWriteCallback), fileStream);
            Console.WriteLine("开始异步写入，请稍候...");
            Console.Read();
        }

        // 异步写操作完成后调用的方法
        static void EndWriteCallback(IAsyncResult asyncResult)
        {
            Console.WriteLine("异步写入开始...");
            FileStream stream = asyncResult.AsyncState as FileStream; // 转换为FileStream类型
            if (stream != null)
            {
                stream.EndWrite(asyncResult);
                stream.Close();
            }
            Console.WriteLine("异步写入完毕!");
        }
    }
}
