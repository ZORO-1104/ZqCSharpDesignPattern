using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern
{
    class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }

        public void SetPartA(string partA)
        {
            PartA = partA;
        }

        public void SetPartB(string partB)
        {
            PartB = partB;
        }

        public void SetPartC(string partC)
        {
            PartC = partC;
        }

        public void ShowProduct()
        {
            Console.WriteLine($"PartA={PartA},PartB={PartB},PartC={PartC}");
        }

    }
}
