using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class PersonDetailManagement
    {
 
        //Method to Add person details in a List
        public static void AddPerson()
        {
            //List to store person details
            List<Person> PeopleList = new List<Person>();
            PeopleList.Add(new Person(2,"Harsha","tn",17));
            PeopleList.Add(new Person(1,"Indu","up",22));
            PeopleList.Add(new Person(8,"Akshaya","punjab",44));
            PeopleList.Add(new Person(21,"Arpita","bihar",77));
            PeopleList.Add(new Person(5,"Megha","kerala",62));
            PeopleList.Add(new Person(4,"Ruju","Banglore",22));

        }
    }
}
