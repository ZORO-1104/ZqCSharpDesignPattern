using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    class LiaoNingFarm : AbstractFarm
    {
        public override AbstractAnimal CreateAnimal()
        {
            return new Tiger();
        }

        public override AbstractPlant CreatePlant()
        {
            return new SunFlower();
        }
    }
}
