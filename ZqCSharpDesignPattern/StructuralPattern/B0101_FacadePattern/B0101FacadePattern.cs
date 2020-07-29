using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0101_FacadePattern
{
    class B0101FacadePattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            ControlCenter cc = new ControlCenter();
            Console.WriteLine("----------------");
            cc.OnwerEnter();
            Console.WriteLine("----------------");
            cc.OnwerLeave();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【外观模式 - 01】");
        }
    }
}
