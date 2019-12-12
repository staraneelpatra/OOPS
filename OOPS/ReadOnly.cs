using System;

namespace OOPS
{
    class Age
    {
       internal int MyProperty { get; set; }
        public static bool s=true;
        public static string name { get; set; }
        public int j;
        public int tim { get; set; }
        readonly int year=9;
        const int p = 4;
        const DateTime today=DateTime.Now;
        public  Age()
        {
            p= 3;
            year = 10;
            s = false;
            name = "smile";
        }
         static Age()
        {
            s = true;
            name = "POKOri";
            j = 9;
        }
        public Age(int x)
        {

            p = x;
            year = x;
        }
         public void display()
        {
            year = 4;
        }
        
    }
    class MainClass
    {
        public static void Main(string[] args)
        { 
            Age age = new Age(32);
            Age.name = "Anil";
            var  yt=Age.s;
            int po = age.j;
            var t=age.MyProperty;
        }
    }
}
