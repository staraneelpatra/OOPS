using System;

namespace Extmethod
{
    public static class Countext
    {
        public static int Getcount(this string str)
        {
            return str.Length;
        }


        public static bool Isgreater(this int i, int value) {
            return i > value;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 43;
          Boolean c=  i.Isgreater(30);

            string x = "Anil";
            int count = x.Getcount();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
