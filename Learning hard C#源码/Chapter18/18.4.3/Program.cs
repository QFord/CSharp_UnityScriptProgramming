using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace _18._3
{
    public class DynamicType2 : IDynamicMetaObjectProvider
    {
        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            Console.WriteLine("开始获得元数据......");
            return new Metadynamic(parameter, this);
        }
    }

    // 自定义Metadynamic类
    public class Metadynamic : DynamicMetaObject
    {
        internal Metadynamic(Expression expression, DynamicType2 value)
            : base(expression, BindingRestrictions.Empty, value)
        {
        }
        // 重写响应成员调用方法
        public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
        {
            // 获得真正的对象
            DynamicType2 target = (DynamicType2)base.Value;
            Expression self = Expression.Convert(base.Expression, typeof(DynamicType2));
            var restrictions = BindingRestrictions.GetInstanceRestriction(self, target);
            // 输出绑定方法名
            Console.WriteLine(binder.Name + " 方法被调用了");
            return new DynamicMetaObject(self, restrictions);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicobj2 = new DynamicType2();
            dynamicobj2.Call();
            Console.Read();
        }
    }
}
