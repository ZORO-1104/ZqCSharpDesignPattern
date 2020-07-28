using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0302_StrategyPattern
{
    class Context
    {
        private AbstractStrategy abstractStrategy;

        public Context(EnumStrategyType enumStrategyType)
        {
            switch (enumStrategyType)
            {
                case EnumStrategyType.StrategyA:
                    abstractStrategy = new ConcreteStrategyA();
                    break;
                case EnumStrategyType.StrategyB:
                    abstractStrategy = new ConcreteStrategyB();
                    break;
                case EnumStrategyType.StrategyC:
                    abstractStrategy = new ConcreteStrategyC();
                    break;
                default:
                    break;
            }
        }

        public void Run()
        {
            abstractStrategy.RunAlgorithm();
        }
    }
}
