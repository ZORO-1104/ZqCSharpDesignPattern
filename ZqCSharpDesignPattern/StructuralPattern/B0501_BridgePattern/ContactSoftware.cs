using System;

namespace ZqCSharpDesignPattern.StructuralPattern.B0501_BridgePattern
{
    internal class ContactSoftware : PhoneSoftware
    {
        public override void RunSoftware()
        {
            Console.WriteLine($"{this.GetType().Name} run ...");
        }
    }
}