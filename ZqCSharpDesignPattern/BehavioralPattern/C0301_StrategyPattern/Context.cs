using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0301_StrategyPattern
{
    class Context
    {
        private AbstractStrategy abstractStrategy;

        public Context(AbstractStrategy abstractStrategy)
        {
            this.abstractStrategy = abstractStrategy;
        }

        public void Run()
        {
            abstractStrategy.RunAlgorithm();
        }
    }
}
