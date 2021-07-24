using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    class PersonDetailManagement
    {
        List<Person> PeopleList = new List<Person>();
        //Method to Add person details in a List
        public void AddPerson()
        {
            //List to store person details
 
            PeopleList.Add(new Person(2,"Harsha","tn",17));
            PeopleList.Add(new Person(1, "Indu", "up", 22));
            PeopleList.Add(new Person(8, "Akshaya", "punjab", 44));
            PeopleList.Add(new Person(21, "Arpita", "bihar", 77));
            PeopleList.Add(new Person(5, "Megha", "kerala", 62));
            PeopleList.Add(new Person(4, "Ruju", "Banglore", 22));
            DisplayDetails(PeopleList);

        }

        //Method to display details
        public static void DisplayDetails(List<Person> peopleList)
        {
            foreach (Person person in peopleList)
            {
                Console.WriteLine("SSN: {0} Name: {1} Address: {2} Age: {3}  ", person.SSN, person.name, person.address, person.age);
            }
        }

        //retrive the top two person detail from the list whose age is less tha 10;
        public void PersonAgeLessThan60()
        {
            Console.WriteLine("\n********* Retriving the top 2 person from list whose age is less than 60 *********\n");
            List<Person> list = PeopleList.FindAll(person => person.age < 60).OrderBy(x => x.age).Take(2).ToList();
            DisplayDetails(list);
        }
    }
}
