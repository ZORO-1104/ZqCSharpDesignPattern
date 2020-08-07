namespace ZqCSharpDesignPattern.StructuralPattern.B0501_BridgePattern
{
    internal abstract class Phone
    {
        protected PhoneSoftware phoneSoftware;

        public void SetSoftware(PhoneSoftware software)
        {
            this.phoneSoftware = software;
        }

        public abstract void Run();
    }
}