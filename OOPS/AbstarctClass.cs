using System;
namespace OOPS
{
    public interface IMachine
    {
        void Display();
    }
    public interface IAutomobile
    {
        void Display();
        
    }

    public abstract class Absclass1
    {
       public abstract void Display();
       public void Print()
        {
            Console.WriteLine();
        }
        public abstract void disp()
        {
            Console.WriteLine();
        }
       public virtual void pri()
        {
            Console.WriteLine();
        }
    }

    public abstract class Absclass2:Absclass1
    {
        public abstract override void pri();
       //public abstract void Display();
    }
    public struct Mystruct1 
    {
    }
    public struct MyStruct2
    {

    }
    public class Machine : Absclass2, IAutomobile
    {
        public abstract void show()
        {            Console.WriteLine();
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }

    public class Automobile
    {
        
    }
    public class Trucks : Automobile, IMachine
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }

        void IMachine.Display()
        {
            throw new NotImplementedException();
        }
    }
    public class AbstractClass
    {
        public static void Main(string[] args)
        {

        }
    }
}
    