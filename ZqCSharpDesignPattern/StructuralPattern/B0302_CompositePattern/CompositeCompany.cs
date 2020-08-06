using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0302_CompositePattern
{
    class CompositeCompany : Component
    {
        private string name;
        private List<Component> lstComponent;

        public CompositeCompany(string name)
        {
            this.name = name;
            lstComponent = new List<Component>();
        }

        public void Add(Component c)
        {
            lstComponent.Add(c);
        }

        public void CommonOperation(int depth)
        {
            //Console.WriteLine($"树枝结点：{name}");
            Console.WriteLine($"{new string('-', depth)}[{depth.ToString()}]{name}");
            foreach (var item in lstComponent)
            {
                //Console.Write($"--");
                //Console.WriteLine($"树枝结点：{name}");
                item.CommonOperation(depth+1);
            }
        }

        public Component GetChild(int index)
        {
            Component component = null;
            if (index>=0 && index<lstComponent.Count)
            {
                component = lstComponent[index];
            }

            return component;
        }

        public void Remove(Component c)
        {
            if (lstComponent.Contains(c))
            {
                lstComponent.Remove(c);
            }
        }
    }
}
