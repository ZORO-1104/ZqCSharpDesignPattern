using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0301_StrategyPattern
{
    class C0301StrategyPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            //Context c = new Context(new ConcreteStrategyA());
            Context c = new Context(new ConcreteStrategyB());
            c.Run();
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【策略模式 - 01】");
        }
    }
}
