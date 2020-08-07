using System;

namespace ZqCSharpDesignPattern.StructuralPattern.B0501_BridgePattern
{
    internal class PhoneBrandA : Phone
    {
        public override void Run()
        {
            Console.WriteLine($"{this.GetType().Name} run ...");
            phoneSoftware.RunSoftware();
        }
    }
}