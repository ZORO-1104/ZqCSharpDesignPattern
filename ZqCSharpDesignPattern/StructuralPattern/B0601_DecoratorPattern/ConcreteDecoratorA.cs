using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0601_DecoratorPattern
{
    internal class ConcreteDecoratorA : AbstractDecorator
    {
        public override void Operation()
        {
            base.Operation();
            SpecificHandle();
        }

        private void SpecificHandle()
        {
            Console.WriteLine($"{this.GetType().Name} 特殊处理。");
        }
    }
}