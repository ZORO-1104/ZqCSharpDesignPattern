using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern
{
    interface IObserver
    {
        void Update();

        void Response(string msg);
    }
}
