using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    class Peanut : AbstractPlant
    {
        public override void Grow()
        {
            Console.WriteLine($"我是{this.GetType().Name}，需要浇水、施肥、除草、除虫，我才开花结果。");
        }
    }
}
