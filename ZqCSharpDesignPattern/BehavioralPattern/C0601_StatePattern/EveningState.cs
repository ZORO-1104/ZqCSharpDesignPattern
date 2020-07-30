using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class EveningState : WorkState
    {
        public override void WriteProgram(WorkContext context)
        {
            if (context.IsFinish==true)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，工作完成，不用加班，我已愉快地下班啦。。。");
            }
            else if (context.CurrentHour <= 21)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，加班写代码，疲惫至极。。。");
            }
            else
            {
                context.SetWorkState(new SleepState());
                context.WriteProgram();
            }
        }
    }
}
