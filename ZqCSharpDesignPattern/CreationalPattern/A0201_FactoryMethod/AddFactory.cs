﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0201_FactoryMethod
{
    class AddFactory : AbstractFactory
    {
        public override AbstractAlgorithm GetAlgorithm()
        {
            return new AddAlgorithm();
        }
    }
}
