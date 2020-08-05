using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0901_MementoPattern
{
    class Originator
    {
        private string name;

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Memento CreateMemento()
        {
            Memento m = new Memento(name, age);
            return m;
        }

        public void SetMemento(Memento m)
        {
            this.name = m.Name;
            this.age = m.Age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"【信息如下】：姓名{name}，年龄{age}。");
        }
    }
}
