using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0901_MementoPattern
{
    class C0901MementoPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            Originator o1 = new Originator();
            Caretaker c1 = new Caretaker();

            o1.Name = "张三";
            o1.Age = 20;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            o1.Name = "李四";
            o1.Age = 25;
            o1.ShowInfo();

            //恢复信息
            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【备忘录模式 - 01】");
        }
    }
}
