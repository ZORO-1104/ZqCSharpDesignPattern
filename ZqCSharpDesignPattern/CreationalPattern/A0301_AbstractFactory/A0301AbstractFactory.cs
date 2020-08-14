using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    internal class A0301AbstractFactory : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            AbstractFarm absFar = null;
            AbstractAnimal absAni = null;
            AbstractPlant absPla = null;

            //absFar = new HebeiFarm();
            absFar = new LiaoNingFarm();

            absAni = absFar.CreateAnimal();
            absPla = absFar.CreatePlant();

            absAni.Eat();
            absPla.Grow();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【抽象工厂模式 - 01】");
        }
    }
}