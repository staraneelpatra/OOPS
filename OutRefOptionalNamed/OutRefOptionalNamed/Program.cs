using System;

namespace OutRefOptionalNamed
{
    
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x ;
            //var c;
            //int a = 10;//actual parameter
            int addout;
            int mulout;
             Square( out addout, out mulout);
            dip(1, 2, 3);
            dip(z: 1, y: 2, x: 3);
            Console.WriteLine(" " + addout+" "+ mulout);

             void Square(  out int add, out int mul, int x = 7)//Optional parameter
            {
                add = x + x;
                mul = x * x;
            }

            void dip(int x, int y, int z)
            {
                Console.WriteLine(x+" "+y+" "+z);
            }
        }
    }
}