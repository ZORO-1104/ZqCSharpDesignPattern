using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0601_DecoratorPattern
{
    internal class B0601DecoratorPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            ConcreteComponentA cca = new ConcreteComponentA();
            AbstractDecorator ac1 = new ConcreteDecoratorA();
            AbstractDecorator ac2 = new ConcreteDecoratorB();

            ac1.SetComponent(cca);
            ac2.SetComponent(ac1);

            ac2.Operation();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【装饰模式 - 01】");
        }
    }
}