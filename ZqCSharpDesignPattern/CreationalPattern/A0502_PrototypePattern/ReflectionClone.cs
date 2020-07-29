using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0502_PrototypePattern
{
    class ReflectionClone : IMyClone
    {
        //用反射，涉及到递归调用
        public object DeepClone<T>(T source)
        {
            //如果是字符串或值类型则直接返回
            if (source is string || source.GetType().IsValueType)
            {
                return source;
            }

            object retval = Activator.CreateInstance(source.GetType());

            //字段
            FieldInfo[] fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                field.SetValue(retval, DeepClone(field.GetValue(source)));
            }

            //属性
            //PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (PropertyInfo property in properties)
            //{
            //    property.SetValue(retval, DeepClone(property.GetValue(source)));
            //}

            return (T)retval;
        }
    }
}
