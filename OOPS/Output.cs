using System;
namespace OOPS
{
    public class Output
    {
        public static void Main(){

            int x = 0;
            int y = 0;

            for (short z = 0; z < 3; z++)
            {
                if ((x++ > 1) || (y++ > 1))
                {
                    x++;
                }
            }
            Console.WriteLine(x + "" + y);
            Console.ReadKey();

            int i = (byte)+(char)-(int)+(long)-1;
            Console.WriteLine(i);


            Console.WriteLine(1);
            http://csharpStar.com/
            Console.WriteLine(2);

            int i1 = 13;
            int j1 = 14;
            i1 = --i1 - i1--;
            j1 = ++j1 + j1++;
            Console.WriteLine(i1 + j1);
            Console.ReadKey();


        }
    }
}
