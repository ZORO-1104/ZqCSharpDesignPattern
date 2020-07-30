using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class C0601StatePattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            WorkContext w1 = new WorkContext();
            w1.CurrentHour = 9;
            w1.WriteProgram();

            w1.CurrentHour = 10;
            w1.WriteProgram();

            w1.CurrentHour = 13;
            w1.WriteProgram();

            w1.CurrentHour = 15;
            w1.WriteProgram();

            w1.CurrentHour = 17;
            w1.WriteProgram();

            w1.CurrentHour = 18;
            w1.IsFinish = true;
            w1.WriteProgram();

            w1.CurrentHour = 22;
            w1.WriteProgram();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【状态模式 - 01】");
        }
    }
}
