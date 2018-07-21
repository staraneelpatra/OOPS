    using System;
    using System.Collections;
    using System.Collections.Generic;
    namespace OOPS
    {
        
        class Oper <T>
        {
            public void Sum(T a, T b)
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
        public class Genriclist
        {
            //List<int> l1 = new List<int>();
                static void Main()
                {
                List<Student> students = new List<Student>();

                Oper<int> oper = new Oper<int>();
                oper.Sum(4, 5);
                Oper<float> oper1 = new Oper<float>();
                oper1.Sub(9.5f, 3.1f); 

                }
        }
    }