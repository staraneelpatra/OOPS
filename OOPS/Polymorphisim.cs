using System;
namespace OOPS
{
    public class Parent{
        public virtual void Print()
        {
            Console.WriteLine("Parent");
        }
    }
    public class Polymorphisim : Parent
    {
        public override void Print()
        {

            Console.WriteLine("Child");
        }
        public static void Main() {
            Parent p1 = new Parent();
            p1.Print();
            Parent pcobj = new Polymorphisim();
            pcobj.Print();
            //Polymorphisim cpobj = (Polymorphisim)p1;
            //cpobj.Print();
            Polymorphisim c1 = new Polymorphisim();
            c1.Print();
            Console.ReadKey();
    }
    }
}
