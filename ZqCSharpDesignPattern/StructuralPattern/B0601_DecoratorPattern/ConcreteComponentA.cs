using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0601_DecoratorPattern
{
    internal class ConcreteComponentA : AbstractComponent
    {
        public override void Operation()
        {
            Console.WriteLine($"{this.GetType().Name} 进行处理。。。");
        }
    }
}