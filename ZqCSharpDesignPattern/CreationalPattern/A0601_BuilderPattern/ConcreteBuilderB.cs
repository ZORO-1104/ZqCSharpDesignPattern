using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern
{
    class ConcreteBuilderB : AbstractBuilder
    {
        public override void BuildPartA()
        {
            product.SetPartA($"{this.GetType().Name}[A]");
        }

        public override void BuildPartB()
        {
            product.SetPartB($"{this.GetType().Name}[B]");
        }

        public override void BuildPartC()
        {
            product.SetPartC($"{this.GetType().Name}[C]");
        }
    }
}
