using System;
using ZqCSharpDesignPattern.BehavioralPattern.C0101_ObserverPattern;
using ZqCSharpDesignPattern.BehavioralPattern.C0301_StrategyPattern;
using ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory;
using ZqCSharpDesignPattern.CreationalPattern.A0201_FactoryMethod;
using ZqCSharpDesignPattern.CreationalPattern.A0301_AbstractFactory;
using ZqCSharpDesignPattern.CreationalPattern.A0401_SingletonPattern;
using ZqCSharpDesignPattern.CreationalPattern.A0601_BuilderPattern;

namespace ZqCSharpDesignPattern
{
    class Program
    {
        static CodeFramework cf = null;

        static void Main(string[] args)
        {
            RunMethod();

            cf.Execute();
        }

        private static void RunMethod()
        {
            cf = new A0101SimpleFactory();
            cf = new A0201FactoryMethod();
            cf = new A0301AbstractFactory();
            cf = new A0601BuilderPattern();
            cf = new A0401SingletonPattern();
            cf = new C0301StrategyPattern();
            cf = new C0101ObserverPattern();
        }
    }
}
