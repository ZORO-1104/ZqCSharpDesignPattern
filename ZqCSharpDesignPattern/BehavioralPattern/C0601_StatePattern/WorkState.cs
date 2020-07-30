using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    abstract class WorkState
    {
        public abstract void WriteProgram(WorkContext context);
    }
}
