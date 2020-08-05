using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0901_MementoPattern
{
    class Caretaker
    {
        private Memento memento;

        public void SetMemento(Memento m)
        {
            memento = m;
        }

        public Memento GetMemento()
        {
            return memento;
        }
    }
}
