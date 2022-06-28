using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Family
    {
        //List<Person> families = new List<Person> ();
        private List<Person> familyList = new List<Person>();
        public List<Person> Familing { get; set; }
        public Family(List<Person> familyList)
        {
            Familing = familyList;
        }
        public static void AddMember(List<Person> familyList, Person per)
        {
            familyList.Add(per);
        }
        public static Person GetOldestMember(List<Person> familyList, Person per)
        {
            int max = int.MinValue;
            string name = "";
            Person oldest = new Person(name, max);
            foreach (Person item in familyList)
            {
                if (item.Age > max)
                {
                    max = item.Age;
                    name = item.Name;
                    oldest = new Person(name, max);

                }
            }
            return oldest;
        }
        public static List<Person> GetAge(List<Person> familyList, List<Person> Age)
        {

            foreach (Person item in familyList)
            {
                if (item.Age > 30)
                {
                    Age.Add(item);
                }
            }
            return Age;

        }

    }
}
