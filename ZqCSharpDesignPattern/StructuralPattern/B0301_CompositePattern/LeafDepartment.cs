using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0301_CompositePattern
{
    class LeafDepartment : Component
    {
        private string name;

        public LeafDepartment(string name)
        {
            this.name = name;
        }
        public void Add(Component c)
        {
            Console.WriteLine("树叶结点，无法添加。。。");
        }

        public void CommonOperation(int depth)
        {
            Console.WriteLine($"{new string('-',depth)}[{depth.ToString()}]{name}");
        }

        public Component GetChild(int index)
        {
            Console.WriteLine("树叶结点，无子节点。。。");
            return null;
        }

        public void Remove(Component c)
        {
            Console.WriteLine("树叶结点，无法删除。。。");
        }
    }
}
