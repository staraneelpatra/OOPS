using System;
namespace OOPS
{
    public interface IMyInterface
    {
         void show();
    }

    public struct MyStruct
    {

    }

    public class MyClass
    {

    }
    public abstract class Measurement:MyClass, IMyInterface
    {
        private int k = 3;
        protected Measurement(){}
          Measurement(int k){
            Console.WriteLine("Called from abstract class constructor"+k);
        }
        public abstract void Area(int a);
        public void Display()
        {
            Console.WriteLine("Abstract implemented method");
        }
        public void show(){}
            

    }
    public class AbstarctClass: Measurement
    {
        
        public override void Area(int a)

        {  
            Console.WriteLine("Area : "+ a);
        }

    }
    class Mainclass : IMyInterface{
        public void show(){}

        public static void Main(){
            AbstarctClass abstarctClass = new AbstarctClass();
            abstarctClass.Area(5);
            abstarctClass.Display();
                         
        }
    }
}