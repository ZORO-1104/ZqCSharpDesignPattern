using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    class SunFlower : AbstractPlant
    {
        public override void Grow()
        {
            Console.WriteLine($"我是{this.GetType().Name}，浇水和见阳光，我就能长大。");
        }
    }
}
