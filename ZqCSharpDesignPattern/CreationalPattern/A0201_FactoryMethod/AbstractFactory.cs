using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0201_FactoryMethod
{
    abstract class AbstractFactory
    {
        public abstract AbstractAlgorithm GetAlgorithm();
    }
}
