using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory
{
    class DivideAlgorithm : AbstractAlgorithm
    {
        protected override double GetResult()
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new Exception("被除数不能为0。");
            }
        }

        protected override string OperationType()
        {
            return "/";
        }
    }
}
