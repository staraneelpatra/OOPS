using System;
namespace OOPS
{
    public abstract class SealedClass
    {
        public abstract void M1();// { }

        public void displaying(object o, dynamic d){

            var r = o + d;
            Console.WriteLine(r);
        }


    }

    public class Child : SealedClass
    {
        
        sealed override public void M1()
        {
            Console.WriteLine("Read");
        }
    }
    public class GChild : Child
    {
        //public override void M1()
        //{

        //}
    }
}