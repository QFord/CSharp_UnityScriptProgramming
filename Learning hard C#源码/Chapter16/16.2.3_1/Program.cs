using System;
using System.Xml;

namespace _16._3
{
    class Program
    {
        // 初始化XML数据
        private static string xmlString =
            "<Persons>" +
            "<Person Id='1'>" +
            "<Name>张三</Name>" +
            "<Age>18</Age>" +
            "</Person>" +
            "<Person Id='2'>" +
            "<Name>李四</Name>" +
            "<Age>19</Age>" +
            "</Person>" +
             "<Person Id='3'>" +
            "<Name>王五</Name>" +
            "<Age>22</Age>" +
            "</Person>" +
            "</Persons>";

        static void Main(string[] args)
        {
            Console.WriteLine("使用XPath来对XML文件查询，查询结果为：");
            OldLinqToXMLQuery();
            Console.Read();
        }     

        // 使用XPath方式来对XML文件进行查询
        private static void OldLinqToXMLQuery()
        {
            // 导入XML文件
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);

            // 创建查询XML文件的XPath
            string xPath = "/Persons/Person";

            // 查询Person元素
            XmlNodeList querynodes = xmlDoc.SelectNodes(xPath);
            foreach (XmlNode node in querynodes)
            {
                // 查询名字为李四的元素
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.InnerXml == "李四")
                    {
                        Console.WriteLine("姓名为： " + childnode.InnerXml + "  Id 为：" + node.Attributes["Id"].Value);
                    }
                }
            }
        }
    }
}
