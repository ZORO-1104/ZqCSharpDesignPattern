using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0201_FactoryMethod
{
    abstract class AbstractAlgorithm
    {
        protected double num1;
        protected double num2;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        protected abstract double GetResult();
        protected abstract string OperationType();

        public void ShowResult()
        {
            string msg = $"{num1} {OperationType()} {num2} = {Math.Round(GetResult(), 5)}";
            Console.WriteLine(msg);
        }
    }
}
