using System;
namespace OOPS
{
    public class ReverseString
    {
        public static void Main(string[] args)
        {
            string s="Anil", rs = "";
             int count = s.Length - 1;
            //while (count>=0)
            //{
            //    rs = rs + s[count];
            //    count--;
            //}
            int postion=0;
            while (count >= 0)
            {
                if (s[count]== 'n') { 
                 postion = count+1;
            }
                count--;
            }
            //Console.WriteLine(rs);
            Console.WriteLine("Postion is {0}", postion);
          Console.ReadKey();
        }
        
    }
}
