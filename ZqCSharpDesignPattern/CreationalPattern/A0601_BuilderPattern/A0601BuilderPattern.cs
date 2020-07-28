using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern
{
    class A0601BuilderPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            Product p = null;
            Director d = null;

            //d = new Director(new ConcreteBuilderA());
            d = new Director(new ConcreteBuilderB());

            //具体建造过程，对客户端来说是隐藏的（避免了客户端使用方由于对产品认识不全面，造成建造）。
            //其产品建造的完整性，由Director来保证。
            //客户端只管调用Construct方法，来建造产品即可。
            p = d.Construct();

            p.ShowProduct();
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【建造者模式】 - 01");
        }
    }
}
