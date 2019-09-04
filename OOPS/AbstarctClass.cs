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
    }

    public abstract class Absclass2
    {
       public abstract void Display();
    }
    public struct Mystruct1 
    {
    }
    public struct MyStruct2
    {

    }
    public class Machine : Absclass2, IAutomobile
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }

    public class Automobile
    {
        
    }
    public class Trucks : Automobile,
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
    