using System;
using System.Collections.Generic;

namespace YieldDemo
{
    class MainClass
    {
        public IEnumerable<int> print()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    yield return i;

                }
            }
        }
        public static void Main(string[] args)
        {
            MainClass x = new MainClass();
            x.print();
        }
    }
}
