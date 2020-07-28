using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory
{
    class MultiplyAlgorithm : AbstractAlgorithm
    {
        protected override double GetResult()
        {
            return num1 * num2;
        }

        protected override string OperationType()
        {
            return "*";
        }
    }
}
