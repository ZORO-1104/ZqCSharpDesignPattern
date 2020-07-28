using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0201_AdapterPattern
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是适配者类，我的调用接口是SpecificRequest。");
        }
    }
}
