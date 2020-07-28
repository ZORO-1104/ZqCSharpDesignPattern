using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern
{
    abstract class AbstractBuilder
    {
        protected Product product = new Product();

        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();

        public Product GetProduct()
        {
            return this.product;
        }
    }
}
