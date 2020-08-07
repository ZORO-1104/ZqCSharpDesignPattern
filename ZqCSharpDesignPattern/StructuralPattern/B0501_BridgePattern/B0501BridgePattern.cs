using System;

namespace ZqCSharpDesignPattern.StructuralPattern.B0501_BridgePattern
{
    internal class B0501BridgePattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        protected override void TestDescription()
        {
            Console.WriteLine($"【桥接模式 - 01】");
        }

        private void Test01()
        {
            Phone p1;
            PhoneSoftware ps1;

            //ps1 = new GameSoftware();
            ps1 = new ContactSoftware();

            //p1 = new PhoneBrandA();
            p1 = new PhoneBrandB();
            p1.SetSoftware(ps1);

            p1.Run();
        }
    }
}