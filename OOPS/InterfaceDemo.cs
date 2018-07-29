using System;
namespace OOPS
{
    public interface ItempEmp
    {
        int calculateSal(int a);
    }
    //public interface IPermEmp{
    //    int calculateSal(int a);
    //}

    public class InterfaceDemo : ItempEmp
    //, IPermEmp
    {
         int calculateSal(int a)
        {
            int sal = a * 12;
            return sal;
        }

        //int IPermEmp.calculateSal(int a)
        //{
        //    throw new NotImplementedException();
        //}
    }
    class MyClass
    {
        public static void Main(){
            InterfaceDemo interfaceDemo = new InterfaceDemo();
            interfaceDemo.
        }
    }
}
