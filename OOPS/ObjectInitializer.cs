using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPS
{
    class StudentName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class ObjectInitializer
    {
        public static void Main()
        {
            List<Cat> cats = new List<Cat>
            {
                new Cat{Name= "Snil",Age=3},
                new Cat{Name="Tiger",Age=33}
            };
            cats.Add(new Cat { Name = "Lio", Age = 3 });

            foreach (Cat item in cats)
            {
                Console.WriteLine(item.Name+" , "+item.Age);
            }
           var students = new Dictionary<int, StudentName>()
            {
            { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
            { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
            { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
            };

            string k=students.Where(x => x.Value.FirstName == "Dina").Select(x => x.Value.LastName).FirstOrDefault();



        }
    }
}
