using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0201_AdapterPattern
{
    class Adapter : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
