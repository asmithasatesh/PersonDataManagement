using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
   public  class PersonDetailManagement
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
        public static List<string> DisplayDetails(List<Person> peopleList)
        {
            List<string> personRecord = new List<string>();
            foreach (Person person in peopleList)
            {
                Console.WriteLine("SSN: {0}\tName: {1}\tAddress:{2}\tAge: {3}  ", person.SSN, person.name, person.address, person.age);
                personRecord.Add(person.name);
            }
            return personRecord;
        }

        //retrive the top two person detail from the list whose age is less tha 10;
        public List<string> PersonAgeLessThan60()
        {

            Console.WriteLine("\n********* Retriving the top 2 person from list whose age is less than 60 *********\n");
            List<Person> list = PeopleList.FindAll(person => person.age < 60).OrderBy(x => x.age).Take(2).ToList();
            List<string> recordList=DisplayDetails(list);
            return recordList;

        }

        //Retriving the record where age is between 13-18
        public List<string> PersonAgeBetween13And18()
        {
            Console.WriteLine("\n********* Retriving the record where age is between 13-18 *********\n");
            List<Person> list = PeopleList.FindAll(person => person.age < 18 && person.age>13);
            List<string> recordList = DisplayDetails(list);
            return recordList;
        }

        //Compute Average of Age
        public double AverageAgeRecord()
        {
            double avgAge = PeopleList.Average(person => person.age);
            Console.WriteLine("Average age value is : {0} ", Math.Round(avgAge,3));
            return Math.Round(avgAge, 3);
        }

        //Search a specific name
        public string SearchingSpecificName(string personName)
        {
            try
            {
                var person = PeopleList.Find(person => person.name.Equals(personName));
                if (personName != null && person == null)
                {
                    Console.WriteLine("Person does not Exist!");
                    return "Not Found";
                }
                if (person.name== personName)
                {
                    Console.WriteLine("Found Person\nSSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
                    return "Found";
                }

    
                throw new ArgumentNullException("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
