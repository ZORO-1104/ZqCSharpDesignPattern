using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0701_ResponsibilityChain
{
    class C0701ResponsibilityChain : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            Request r1 = new Request() {Data = 778 };

            AbstractHandler h1 = new ConcreteHandlerA();
            AbstractHandler h2 = new ConcreteHandlerB();
            AbstractHandler h3 = new ConcreteHandlerC();

            //在客户端，设置职责链
            h1.SetNextHandler(h2);
            h2.SetNextHandler(h3);
            //h3.SetNextHandler(h1);//职责链设置错误，造成循环

            //处理请求
            bool result = h1.DisposeRequest(r1);
            Console.WriteLine(result);
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【职责链模式 - 01】");
        }
    }
}
