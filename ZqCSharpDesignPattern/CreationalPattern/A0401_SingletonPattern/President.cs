using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0401_SingletonPattern
{
    class President
    {
        private static President president;
        private static readonly object sync = new object();

        private static int count = 0;
        public static int Count { get => count;}

        private President()
        {
            count++;
        }

        public static President GetPresident()
        {
            if (null==president)
            {
                lock (sync)
                {
                    if (null==president)
                    {
                        president = new President();
                    }
                }
            }

            return president;
        }
    }
}
