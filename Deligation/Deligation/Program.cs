using System;

namespace Deligation
{
    public delegate void MyDeligate(int x, int y);
    class Program
    {
      public void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public static void mul (int c, int d)
        {
            Console.WriteLine(c*d);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            //MyDeligate del = new MyDeligate(p.add);
            //del.Invoke(2, 3);
            //MyDeligate del2 = new MyDeligate(Program.mul);
            //del2(3, 4);

            MyDeligate del = null;
            del += p.add;
            del += Program.mul;
            del.Invoke(5, 2);

        }
    }
}
