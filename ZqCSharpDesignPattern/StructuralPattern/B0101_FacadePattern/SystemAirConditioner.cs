using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0101_FacadePattern
{
    class SystemAirConditioner
    {
        public void Open()
        {
            Console.WriteLine("空调开始运行了。。。");
        }

        public void Close()
        {
            Console.WriteLine("空调关闭了。。。");
        }
    }
}
