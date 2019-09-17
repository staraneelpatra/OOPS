using System;
using System.Collections;
namespace OOPS
{
    class Hashtable1
    {
        Hashtable ht = new Hashtable();

    }
    public class Collections
    {
        public static void Main(){

            Hashtable ht = new Hashtable();
            ht.Add("First", "Hello");
            ht.Add("Second", "World");

            Console.WriteLine(ht.Count);
            Console.ReadKey();
        }
    }

}
