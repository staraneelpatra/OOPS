using System;
namespace OOPS
{
    interface testInterface1
    {
        void Show();
    }
    interface testInterface2
    {
        void Show();
    }
    class Abc : testInterface1,
        testInterface2
    {
        void testInterface1.Show()
        {
            Console.WriteLine("For testInterface1 !!");
        }
        void testInterface2.Show()
        {
            Console.WriteLine("For testInterface2 !!");
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            testInterface1 obj1 = new Abc();
            testInterface1 obj2 = new Abc();
            obj1.Show();
            obj2.Show();
            Console.ReadLine();
        }
    }
}
