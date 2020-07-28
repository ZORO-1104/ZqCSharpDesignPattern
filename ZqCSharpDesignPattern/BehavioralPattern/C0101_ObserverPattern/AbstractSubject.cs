using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern
{
    abstract class AbstractSubject
    {
        protected List<IObserver> lstObserver = new List<IObserver>();

        public void Add(IObserver observer)
        {
            lstObserver.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            if (lstObserver.Contains(observer))
            {
                lstObserver.Remove(observer);
            }
        }

        public abstract void Notify();
    }
}
