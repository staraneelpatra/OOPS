using System;
namespace OOPS
{
    class Parent
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Sum(int x, int y, int z, int a)
        {
            return x + y + z + a;
        }

        public string Sum(string x)
        {
            return x;
        }
    }

    class Child:Parent
    {
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }
    public class Polymorphism
    {
         static Polymorphism()
        {
        }
    }
}
