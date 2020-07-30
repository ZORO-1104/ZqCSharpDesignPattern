using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class SleepState : WorkState
    {
        public override void WriteProgram(WorkContext context)
        {
            if (context.IsFinish == true)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，工作完成，不用加班，我已躺床上睡觉了。。。");
            }
            else if (context.CurrentHour>21)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，不行了，我要睡着了。。。");
            }
        }
    }
}
