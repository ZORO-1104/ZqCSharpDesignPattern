using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0302_StrategyPattern
{
    class C0302StrategyPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            Context c = null;
            //c = new Context(EnumStrategyType.StrategyA);
            //c = new Context(EnumStrategyType.StrategyB);
            c = new Context(EnumStrategyType.StrategyC);
            c.Run();
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【策略模式 - 02】");
        }
    }
}
