using System;
using System.Dynamic;

namespace _18._2
{
    class DynamicType : DynamicObject
    {
        // 重写TryXXX方法，该方法表示对对象的动态调用
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + " 方法正在被调用");
            result = null;
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            Console.WriteLine(binder.Name + " 属性被设置，" + "设置的值为： " + value);
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicobj = new DynamicType();
            dynamicobj.CallMethod();
            dynamicobj.Name = "Learning Hard";
            dynamicobj.Age = "24";
            Console.Read();
        }   
    }
}
