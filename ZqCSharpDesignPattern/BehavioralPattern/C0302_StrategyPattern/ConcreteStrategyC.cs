using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0302_StrategyPattern
{
    class ConcreteStrategyC : AbstractStrategy
    {
        public override void RunAlgorithm()
        {
            Console.WriteLine("我是实际策略C类，我通过看书想算法。。。");
        }
    }
}
