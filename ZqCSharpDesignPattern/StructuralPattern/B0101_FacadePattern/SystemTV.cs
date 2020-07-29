using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0101_FacadePattern
{
    class SystemTV
    {
        public void Open()
        {
            Console.WriteLine("电视打开了。。。");
        }

        public void Close()
        {
            Console.WriteLine("电视关闭了。。。");
        }
    }
}
