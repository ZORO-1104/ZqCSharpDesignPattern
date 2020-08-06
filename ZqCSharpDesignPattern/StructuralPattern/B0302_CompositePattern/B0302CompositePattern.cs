using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0302_CompositePattern
{
    class B0302CompositePattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            CompositeCompany c1 = new CompositeCompany("北京总公司");
            CompositeCompany c2 = new CompositeCompany("东北总公司");
            CompositeCompany c3 = new CompositeCompany("华北总公司");
            CompositeCompany c4 = new CompositeCompany("华南总公司");
            CompositeCompany c5 = new CompositeCompany("西北总公司");

            LeafDepartment le1 = new LeafDepartment("人事部");
            LeafDepartment le2 = new LeafDepartment("行政部");
            LeafDepartment le3 = new LeafDepartment("财务部");
            LeafDepartment le4 = new LeafDepartment("人事部");
            LeafDepartment le5 = new LeafDepartment("销售部");
            LeafDepartment le6 = new LeafDepartment("技术部");

            c1.Add(c2);
            c1.Add(c3);
            c1.Add(c4);
            c1.Add(c5);
            c1.Add(le1);

            c2.Add(le2);
            c3.Add(le3);
            c4.Add(le4);
            c5.Add(le5);

            c2.Add(c3);

            c3.Add(c5);

            c1.CommonOperation(1);

            Console.WriteLine();
            Console.WriteLine();

            c1.GetChild(0)?.CommonOperation(1);
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【组合模式 - 01：透明方式】");
        }
    }
}
