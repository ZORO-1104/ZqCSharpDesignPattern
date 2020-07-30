using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0601_StatePattern
{
    class WorkContext
    {
        public int CurrentHour { get; set; }
        public bool IsFinish { get; set; }

        private WorkState workState;

        public WorkContext()
        {
            workState = new MorningState(); 
        }

        public void SetWorkState(WorkState workState)
        {
            this.workState = workState;
        }

        public void WriteProgram()
        {
            workState.WriteProgram(this);
        }
    }
}
