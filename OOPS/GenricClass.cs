    using System;
    using System.Collections;
    using System.Collections.Generic;
    namespace OOPS
    {
        
        class Oper <T,T1> //where T1:IEnumerable
        {
            public void Sum(T a, T1 b)
            {
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x + y);
                //return x + y;
            }

            public void Sub(T a, T b)
            {
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x - y);
                //return x + y;
            }
        }

    class Multi 
    {
        public int Product1 <T,T1>(T a, T1 b) //where T1:Int64//Oper<float,int>
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
    }
        public class Genriclist
        {
            //List<int> l1 = new List<int>();
                static void Main()
                {
                List<Student> students = new List<Student>();

                Oper<int,float> oper = new Oper<int,float>();
                oper.Sum(4, 5.78f);
                Oper<float,float> oper1 = new Oper<float,float>();
                oper1.Sub(9.5f, 3.1f);

                Multi m = new Multi();
                m.Product1<float,int>(4.3f, 3);

                }
        }
    }