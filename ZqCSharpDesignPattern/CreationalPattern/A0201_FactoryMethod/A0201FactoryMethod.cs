using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0201_FactoryMethod
{
    class A0201FactoryMethod : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            AbstractFactory absFac = null;
            AbstractAlgorithm absAlg = null;

            //absFac = new AddFactory();
            absFac = new MultiplyFactory();

            absAlg = absFac.GetAlgorithm();
            absAlg.Num1 = 10.11;
            absAlg.Num2 = 20.22;
            absAlg.ShowResult();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【工厂方法模式 - 01】");
        }
    }
}
