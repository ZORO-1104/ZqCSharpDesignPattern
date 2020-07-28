using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern
{
    abstract class CodeFramework
    {
        protected abstract void TestDescription();
        protected abstract void RunCode();

        public void Execute()
        {
            Console.WriteLine($"<<<<<<测试开始>>>>>>");
            TestDescription();
            RunCode();

            Console.WriteLine($"<<<<<<测试结束>>>>>>");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("【提示】：按任意键退出。。。");
            Console.ReadLine();
        }
    }
}
