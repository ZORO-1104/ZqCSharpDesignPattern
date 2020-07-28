using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0202_AdapterPattern
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            //由于Adapter类继承自Adaptee类，
            //而Adaptee类中有公有方法SpecificRequest方法
            //故此处可以直接调用被适配者Adaptee类的方法
            base.SpecificRequest();
        }
    }
}
