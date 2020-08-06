using System;
using System.Collections.Generic;
using System.Text;
using ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory;

namespace ZqCSharpDesignPattern.StructuralPattern.B0302_CompositePattern
{
    interface Component
    {
        void CommonOperation(int depth);
    }
}
