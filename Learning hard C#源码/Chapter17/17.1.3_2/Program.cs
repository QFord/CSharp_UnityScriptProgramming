using Microsoft.Office.Interop.Word;

namespace _17._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 启动Word并使Word可见
            Application wordApp = new Application() { Visible = true };

            // 新建Word文档
            wordApp.Documents.Add();
            Document wordDoc = wordApp.ActiveDocument;
            Paragraph para = wordDoc.Paragraphs.Add();
            para.Range.Text = "欢迎你，进入Learning Hard博客";

            // 保存文档
            object filename = @"D:\learninghard.doc";

            // 使用命名参数使得代码更加易懂
            wordDoc.SaveAs(FileName: filename);

            // 关闭Word
            wordDoc.Close();
            wordApp.Application.Quit();
        }
    }
}
