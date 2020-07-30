using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class NoonState : WorkState
    {
        public override void WriteProgram(WorkContext context)
        {
            if (context.CurrentHour <= 13)
            {
                Console.WriteLine($"当前时间：{context.CurrentHour}点，中午不写代码，吃饭，午休哈。。。");
            }
            else
            {
                context.SetWorkState(new AfternoonState());
                context.WriteProgram();
            }
        }
    }
}
