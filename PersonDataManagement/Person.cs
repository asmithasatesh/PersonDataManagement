using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class Person
    {
        //Instance Variables
        public int SSN;
        public string name;
        public string address;
        public int age;

        //Default constructor
        public Person(int id, string name, string address, int age)
        {
            this.SSN = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }

}
