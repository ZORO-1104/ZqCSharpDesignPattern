﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    class Sheep : AbstractAnimal
    {
        public override void Eat()
        {
            Console.WriteLine($"我是{this.GetType().Name}，我以吃草为生。");
        }
    }
}
