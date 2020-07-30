using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class AfternoonState : WorkState
    {
        public override void WriteProgram(WorkContext context)
        {
            if (context.CurrentHour <= 17)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，下午写代码，还凑合，继续加油，嘎嘎。。。");
            }
            else
            {
                context.SetWorkState(new EveningState());
                context.WriteProgram();
            }
        }
    }
}
