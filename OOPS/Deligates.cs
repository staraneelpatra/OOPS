using System;
namespace OOPS
{
    public delegate int Counting(int x, int y);
    public class Deligates
    {
        public  int Sum(int x, int y)
        {
            return x + y;
        }

        public int Prod(int p, int q)
        {
            return p * q;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Deligates d = new Deligates();
            Counting c = new Counting(d.Sum);
            Console.WriteLine(c.Invoke(3, 4));
            Console.WriteLine();

            Counting c1 = null;
            c1 += d.Sum;
            c1 += d.Prod;
            c.Invoke(2, 3);

            
        }
    }
}
