using System;
using System.Collections.Generic;
using System.Collections;
namespace OOPS
{
    public class Test{
        public int kl { get; set; }
    }
    public class Empinfo : IComparable<Empinfo>{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Empinfo other)
        {
            if (this.Id>other.Id)
            {
                return 1;
            }
            else if(this.Id<other.Id){
                return -1;
            }
            else
                return 0;
        }
    }
    public class Comaprer
    {
        public static void Main(){
            //List<int> i = new List<int>();
            //i.Sort();

            List<Empinfo> infolist = new List<Empinfo>();
            Empinfo e1 = new Empinfo();
            e1.Id = 2;
            e1.Name = "Hulk";
            e1.Age = 65;
            e1.Salary = 3234.32;

            Empinfo e2 = new Empinfo { Id = 3, Name = "Loki", Age = 23, Salary = 232.232 };

            infolist.Add(e1);
            infolist.Add(new Empinfo { Id = 1, Name = "Anil", Age = 29, Salary = 23232 });

            infolist.Add(e2);

            infolist.Sort();

            foreach (Empinfo item in infolist)
            {
                Console.WriteLine("Id= "+item.Id+" Name "+item.Name);

            }

            List<Empinfo> ei = new List<Empinfo>() { e1, e2,};
            foreach (var item in ei)
            {
                Console.WriteLine(item.Name+"  "+item.Salary);
            }

            Console.ReadKey();
        }

    }
}
