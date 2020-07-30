using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0701_ResponsibilityChain
{
    abstract class AbstractHandler
    {
        protected AbstractHandler nextHandler;

        public abstract bool  DisposeRequest(Request rst);

        public void SetNextHandler(AbstractHandler abstractHandler)
        {
            nextHandler = abstractHandler;
        }
    }
}
