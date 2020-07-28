using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    class HebeiFarm : AbstractFarm
    {
        public override AbstractAnimal CreateAnimal()
        {
            return new Sheep();
        }

        public override AbstractPlant CreatePlant()
        {
            return new Peanut();
        }
    }
}
