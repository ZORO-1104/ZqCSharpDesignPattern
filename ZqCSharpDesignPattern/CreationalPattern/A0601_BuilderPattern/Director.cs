using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern
{
    class Director
    {
        private AbstractBuilder abstractBuilder;

        public Director(AbstractBuilder abstractBuilder)
        {
            this.abstractBuilder = abstractBuilder;
        }

        public Product Construct()
        {
            abstractBuilder.BuildPartA();
            abstractBuilder.BuildPartB();
            abstractBuilder.BuildPartC();

            return abstractBuilder.GetProduct();            
        }
    }
}
