using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern
{
    internal class A0601BuilderPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            //客户端使用建造者模式中的角色
            Product p = null;//产品
            Director d = null;//指挥者
            AbstractBuilder absBud = null;//抽象建造者

            //实例化抽象建造者，将其实例化为具体的建造者
            //absBud = new ConcreteBuilderA();
            absBud = new ConcreteBuilderB();

            //实例化指挥者（将抽象建造者通过构造器注入进去）
            d = new Director(absBud);

            //具体建造过程，对客户端来说是隐藏的（避免了客户端使用方由于对产品认识不全面，造成建造错误）。
            //其产品建造的完整性，由Director来保证。
            //客户端只管调用Construct方法，来建造产品即可。
            p = d.Construct();

            //调用产品的通用接口ShowProduct
            p.ShowProduct();
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【建造者模式】 - 01");
        }
    }
}