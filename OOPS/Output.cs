using System;
namespace OOPS
{ public class Parent
    {
    public virtual void Add(int y ,int u)
    {

            Console.WriteLine(y+u);

        }
    }
     public class Small:Parent
    {
       sealed public override void Add(int y, int u)
        {
            Console.WriteLine(y - u);
        }
    }

    public class Tiny : Small
    {
        public override void Add(int y, int u)
        {
            Console.WriteLine(y * u);
        }
    }
    public class Output
    {

        public static void Main(){

        }
    }
}
