using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory
{
    class SimpleFactory
    {
        public static AbstractAlgorithm GetAlgorithm(AlgorithmType algorithmType)
        {
            AbstractAlgorithm abstractAlgorithm = null;

            switch (algorithmType)
            {
                case AlgorithmType.Add:
                    abstractAlgorithm = new AddAlgorithm();
                    break;
                case AlgorithmType.Subtract:
                    abstractAlgorithm = new SubtractAlgorithm();
                    break;
                case AlgorithmType.Multiply:
                    abstractAlgorithm = new MultiplyAlgorithm();
                    break;
                case AlgorithmType.Divide:
                    abstractAlgorithm = new DivideAlgorithm();
                    break;
                default:
                    break;
            }

            return abstractAlgorithm;
        }
    }
}
