using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0701_ResponsibilityChain
{
    class ConcreteHandlerC : AbstractHandler
    {
        public override bool DisposeRequest(Request rst)
        {
            if (rst.Data <= 100)
            {
                Console.WriteLine($"我是{this.GetType().Name}，请求被批准。。。");
                return true;
            }
            else
            {
                Console.WriteLine($"我是{this.GetType().Name}，我没有处理该请求的权限。。。");

                //如果其后继处理类不为空，则将请求交给其下一个结点
                return nextHandler?.DisposeRequest(rst)??false;
            }
        }
    }
}
