﻿using System;
namespace OOPS
{
    public  class Statics
    {
        //public void Print(){Console.WriteLine("Not a Static Method"); }
        public static void Display(){Console.WriteLine("Is  Static Method"); }
        public const int a = 20;
        public static int b = 30;
        //public readonly int y = 90;
        //int k = 0;

    }

    public struct Base{
        
    }

class MyClass
    {
        public static void  Main(){
            Statics statics = new Statics();
            Console.WriteLine(Statics.a);
            Console.WriteLine(OOPS.Statics.b);
            Statics.Display();
            Console.ReadKey();
        }
    }
}
