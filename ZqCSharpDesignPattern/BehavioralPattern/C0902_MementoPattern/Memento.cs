using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0902_MementoPattern
{
    class Memento
    {
        private string name;
        private int age;

        public string Name { get=>name; }
        public int Age { get=>age;  }

        public Memento(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
