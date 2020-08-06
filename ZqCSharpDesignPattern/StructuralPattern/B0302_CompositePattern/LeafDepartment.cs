using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0302_CompositePattern
{
    class LeafDepartment : Component
    {
        private string name;

        public LeafDepartment(string name)
        {
            this.name = name;
        }

        public void CommonOperation(int depth)
        {
            Console.WriteLine($"{new string('-',depth)}[{depth.ToString()}]{name}");
        }
    }
}
