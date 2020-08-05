using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0902_MementoPattern
{
    class Caretaker
    {
        private Stack<Memento> stkMemento;
        private int count;
        private int MaxCount = 5;

        public Caretaker()
        {
            stkMemento = new Stack<Memento>();
            count = 0;
        }

        public void SetMemento(Memento m)
        {
            if (MaxCount > count)
            {
                stkMemento.Push(m);
                count++;

                Console.WriteLine($"保存信息成功，当前已保存了{count}条信息。");
            }
            else
            {
                Console.WriteLine($"保存失败，最多允许保存{MaxCount}个。");
            }
        }

        public Memento GetMemento()
        {
            if (stkMemento.Count != 0)
            {
                count--;
                return stkMemento.Pop();
            }
            else
            {
                return null;
            }
        }
    }
}
