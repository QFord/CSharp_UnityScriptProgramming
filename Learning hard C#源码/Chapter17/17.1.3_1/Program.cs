using System;
using Microsoft.Office.Interop.Word;

namespace _17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            object missing = Type.Missing;

            // 启动Word应用程序并使Word可见
            Application wordApp = new Application { Visible = true };
            // 新建一个Word文档
            wordApp.Documents.Add(ref missing,ref missing,
                                  ref missing,ref missing);
            Document wordDoc = wordApp.ActiveDocument;
            // 添加一个段落
            Paragraph para = wordDoc.Paragraphs.Add(ref missing);
            para.Range.Text = "欢迎你，进入Learning Hard博客";

            // 保存文档
            object filename = @"D:\learninghard.doc";
            object format =WdSaveFormat.wdFormatDocument97;
            wordDoc.SaveAs(ref filename,ref format,
                           ref missing,ref missing,ref missing,ref missing,ref missing,ref missing,
                           ref missing,ref missing,ref missing,ref missing,ref missing,ref missing,
                           ref missing,ref missing);

            // 关闭word文档和Word应用程序
            wordDoc.Close(ref missing,ref missing,ref missing);
            wordApp.Application.Quit(ref missing,ref missing,ref missing);
        }
    }
}
