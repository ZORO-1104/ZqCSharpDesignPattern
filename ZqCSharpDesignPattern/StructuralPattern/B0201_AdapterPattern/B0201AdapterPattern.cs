using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0201_AdapterPattern
{
    class B0201AdapterPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }
        private void Test01()
        {
            ITarget target = new Adapter();
            target.Request();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【适配器模式- 01，对象适配器】");
        }
    }
}
