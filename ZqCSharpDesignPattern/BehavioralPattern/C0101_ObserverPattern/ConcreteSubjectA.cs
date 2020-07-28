using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern
{
    class ConcreteSubjectA : AbstractSubject
    {
        public override void Notify()
        {
            foreach (var item in lstObserver)
            {
                item.Update();
                item.Response("发出通知消息：饭做好了");
            }
        }
    }
}
