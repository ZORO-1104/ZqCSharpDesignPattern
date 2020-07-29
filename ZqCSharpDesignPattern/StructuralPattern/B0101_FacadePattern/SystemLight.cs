using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0101_FacadePattern
{
    class SystemLight
    {
        public void LightOn()
        {
            Console.WriteLine("电灯打开了。。。");
        }

        public void LightOff()
        {
            Console.WriteLine("电灯熄灭了。。。");
        }
    }
}
