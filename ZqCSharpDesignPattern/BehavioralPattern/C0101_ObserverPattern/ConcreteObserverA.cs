using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern
{
    class ConcreteObserverA : IObserver
    {
        string name;

        public ConcreteObserverA(string name)
        {
            this.name = name;
        }

        public void Response(string msg)
        {
            Console.WriteLine($"观察者A[{name}]，接到消息[{msg}]，执行处理。。。");
        }

        public void Update()
        {
            Console.WriteLine($"观察者A[{name}]，接到消息啦。。。");
        }
    }
}
