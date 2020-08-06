using System;
using System.Collections.Generic;
using System.Text;
using ZqCSharpDesignPattern.CreationalPattern.A0101_SimpleFactory;

namespace ZqCSharpDesignPattern.StructuralPattern.B0301_CompositePattern
{
    interface Component
    {
        void Add(Component c);

        void Remove(Component c);

        Component GetChild(int index);

        void CommonOperation(int depth);
    }
}
