using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0302_StrategyPattern
{
    class ConcreteStrategyA : AbstractStrategy
    {
        public override void RunAlgorithm()
        {
            Console.WriteLine("我是实际策略类A，我用脑袋想算法。。。");
        }
    }
}
