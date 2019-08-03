using System;

namespace StaticN
{
    static class StaticClass
    {
        public static int id=1;
        public static string name = "Anil";

        //static StaticClass()
        //{
        //    id = 2;
        //    name = "Aneel";
        //    Console.WriteLine(id +"/t"+name );
        //}

        public static void getdetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //StaticClass.id = 3;
            //StaticClass.name = "Animalking";
            //Console.WriteLine(StaticClass.id + "/t"+ StaticClass.name);
            StaticClass.getdetails();
        }
    }
}
