using System;

namespace OOPS
{
    class Age
    {
        readonly int year;

        public Age(int year){
            this.year = year;
            year = 321;
        }

        public Age(){
            year = 32;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Age age = new Age(32);

            Console.WriteLine("Hello World!");
        }
    }
}
