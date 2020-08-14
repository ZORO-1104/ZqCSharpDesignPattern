using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0601_DecoratorPattern
{
    internal class ConcreteDecoratorB : AbstractDecorator
    {
        public override void Operation()
        {
            base.Operation();
            MyHandle();
        }

        private void MyHandle()
        {
            Console.WriteLine($"{this.GetType().Name} 特殊处理。");
        }
    }
}