using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0501_PrototypePattern
{
    class Student : ICloneable
    {
        private string name;
        private int age;
        private double score;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Score { get => score; set => score = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"姓名：{name}，年龄：{age}，分数：{score}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
