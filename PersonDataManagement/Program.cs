using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management!");
            //Add person Details
            PersonDetailManagement personDetailManagement = new PersonDetailManagement();
            personDetailManagement.AddPerson();

            //Retrieve top two records which age is less than 60
            personDetailManagement.PersonAgeLessThan60();
            
            //Retriving the record where age is between 13-18
            personDetailManagement.PersonAgeBetween13And18();
            
            //Print Average Age 
            personDetailManagement.AverageAgeRecord();
            
            //Search a name
            Console.WriteLine("Enter name to be searched");
            string personName = Console.ReadLine();
            personDetailManagement.SearchingSpecificName(personName);
            
            //Skip record less than 60
            personDetailManagement.SkipRecordLessThan60();

            //Remove a string
            personDetailManagement.RemoveSpecificName("Megha");
        }
    }
}
