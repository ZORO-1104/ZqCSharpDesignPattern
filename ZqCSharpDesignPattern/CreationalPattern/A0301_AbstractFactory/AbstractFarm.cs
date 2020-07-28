using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory
{
    abstract class AbstractFarm
    {
        //创建动物
        public abstract AbstractAnimal CreateAnimal();

        //创建植物
        public abstract AbstractPlant CreatePlant();
    }
}
