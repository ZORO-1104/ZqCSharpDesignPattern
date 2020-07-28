using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern
{
    class ConcreteObserverB : IObserver
    {
        string name;

        public ConcreteObserverB(string name)
        {
            this.name = name;
        }

        public void Response(string msg)
        {
            Console.WriteLine($"观察者B[{name}]，接到消息[{msg}]，执行处理。。。");
        }

        public void Update()
        {
            Console.WriteLine($"观察者B[{name}]，接到消息啦。。。");
        }
    }
}
