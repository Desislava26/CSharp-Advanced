
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            //Person person = new Person();
            //Person person1 = new Person(18);
            //Person person2 = new Person("Jose", 43);

            int n = int.Parse(Console.ReadLine());
            List<Person> familyList = new List<Person>();
            List<Person> Age = new List<Person>();
            Person per = new Person();
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split();
                string name = array[0];
                int age = int.Parse(array[1]);
                per = new Person(name,age);
                //familyList.Add(per);
                Family.AddMember(familyList,per);
                Family listing = new Family(familyList);

            }
            // Person result = Family.GetOldestMember(familyList, per);
            // Console.WriteLine($"{result.Name} {result.Age}");
            Family.GetAge(familyList, Age);
            foreach (var result in Age.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{result.Name} - {result.Age}");
            }

        }
    }
}
