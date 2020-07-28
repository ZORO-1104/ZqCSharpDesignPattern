using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0301_StrategyPattern
{
    class ConcreteStrategyB : AbstractStrategy
    {
        public override void RunAlgorithm()
        {
            Console.WriteLine("我是实际策略B类，我用脚指头想算法，嘎嘎。。。");
        }
    }
}
