using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0401_SingletonPattern
{
    class A0401SingletonPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            President p1 = President.GetPresident();
            Console.WriteLine($"count={President.Count}");

            President p2 = President.GetPresident();
            Console.WriteLine($"count={President.Count}");

            President p3 = President.GetPresident();
            President p4 = President.GetPresident();
            Console.WriteLine($"count={President.Count}");
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【单例模式 - 01】");
        }
    }
}
