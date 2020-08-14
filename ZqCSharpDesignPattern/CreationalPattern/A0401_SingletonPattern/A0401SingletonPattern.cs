using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0401_SingletonPattern
{
    internal class A0401SingletonPattern : CodeFramework
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

            Console.WriteLine("判断是否相等");
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1 == p4);
            Console.WriteLine(p1.GetHashCode().ToString());
            Console.WriteLine(p2.GetHashCode().ToString());
            Console.WriteLine(p3.GetHashCode().ToString());
            Console.WriteLine(p4.GetHashCode().ToString());

            /*
            count=1
            count=1
            count=1
            判断是否相等
            True
            True
            True
            58225482
            58225482
            58225482
            58225482
             */
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【单例模式 - 01】");
        }
    }
}