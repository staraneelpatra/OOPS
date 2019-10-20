using System;
namespace OOPS
{
    public class WordCount
    {
        public virtual void show()
        {
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            String Sentc = " I am a human being who loves to enjoy life ";
            int count = 1;
            Sentc = Sentc.Trim();
            for (int i = Sentc.Length-1; i >= 0; i--)
            {
                if (Sentc[i]==' ')
                {
                    count += 1;
                }
            }
            Console.WriteLine("Number of Words is {0}", count);
           Console.ReadKey();
        }
    }
    abstract class AA
    {
        public void Display()
        {
            Console.WriteLine();
        }
        public abstract void Print();
    }
}
