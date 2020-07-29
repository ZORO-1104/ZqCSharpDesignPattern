using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0502_PrototypePattern
{
    interface IMyClone
    {
        object DeepClone<T>(T source);
    }
}
