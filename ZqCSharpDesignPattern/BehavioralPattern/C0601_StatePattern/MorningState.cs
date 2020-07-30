using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class MorningState : WorkState
    {
        public override void WriteProgram(WorkContext context)
        {
            if (context.CurrentHour<=12)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，上午写代码，精神百倍，嘎嘎。。。");
            }
            else
            {
                context.SetWorkState(new NoonState());
                context.WriteProgram();
            }
        }
    }
}
