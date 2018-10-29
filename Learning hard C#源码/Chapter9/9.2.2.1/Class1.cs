using System;


namespace EventUse1
{
    class Test
    {
        public static void DoTest()
        {
            Friend f1 = new Friend();
            f1.Name = "A1";
            Bridegroom b = new Bridegroom();
            b.NotifyDate += new EventHandler(f1.Response);
        }
    }

    internal class Bridegroom
    {

        public event EventHandler NotifyDate;

        public void SendMsg()
        {
            NotifyDate?.Invoke(this, new EventArgs());//null 条件运算符
        }

    }

internal class Friend
    {
        public string Name
        {
            get;
            set;
        }

        public void Response(object sender,EventArgs e)
        {
            Console.WriteLine("sender:"+sender.ToString()+"  "+Name + "收到了请帖！");
        }
    }


}
