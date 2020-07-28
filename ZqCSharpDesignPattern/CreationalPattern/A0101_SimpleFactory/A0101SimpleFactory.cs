using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory
{
    class A0101SimpleFactory : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【简单工厂模式-01】");
        }

        private void Test01()
        {
            AbstractAlgorithm a1 = SimpleFactory.GetAlgorithm(AlgorithmType.Add);
            a1.Num1 = 20;
            a1.Num2 = 30.23;
            a1.ShowResult();

            AbstractAlgorithm a2 = SimpleFactory.GetAlgorithm(AlgorithmType.Subtract);
            a2.Num1 = 20;
            a2.Num2 = 30.23;
            a2.ShowResult();

            AbstractAlgorithm a3 = SimpleFactory.GetAlgorithm(AlgorithmType.Multiply);
            a3.Num1 = 20;
            a3.Num2 = 30.23;
            a3.ShowResult();

            AbstractAlgorithm a4 = SimpleFactory.GetAlgorithm(AlgorithmType.Divide);
            a4.Num1 = 20;
            a4.Num2 = 30.23;
            a4.ShowResult();
        }
    }
}
