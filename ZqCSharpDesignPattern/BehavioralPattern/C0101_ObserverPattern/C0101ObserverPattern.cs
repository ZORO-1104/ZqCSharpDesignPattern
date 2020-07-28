using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern
{
    class C0101ObserverPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            AbstractSubject abstractSubject = new ConcreteSubjectA();

            IObserver o1 = new ConcreteObserverA("张三");
            IObserver o2 = new ConcreteObserverB("李四");
            IObserver o3 = new ConcreteObserverA("赵五");
            IObserver o4 = new ConcreteObserverA("王六");

            abstractSubject.Add(o1);
            abstractSubject.Add(o2);
            abstractSubject.Add(o3);
            abstractSubject.Add(o4);
            abstractSubject.Add(o1);

            abstractSubject.Notify();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【观察者模式 - 01】");
        }
    }
}
