using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDataManagement;
using System;
using System.Collections.Generic;

namespace PersonDetailTesting
{
    [TestClass]
    public class UnitTest1
    {
        PersonDetailManagement personDetailManagement;
        [TestInitialize]
        public void TestSetup()
        {

            personDetailManagement = new PersonDetailManagement();
            personDetailManagement.AddPerson();

        }
        //Usecase 2
        [TestMethod]
        [TestCategory("Retrieve Top two Records")]
        public void GivenRecord_ReturnTop2_AgeLessThan60()
        {
            List<string> expected = new List<string> { "Harsha","Indu"};
            List<string> actual = personDetailManagement.PersonAgeLessThan60();
            CollectionAssert.AreEqual(expected, actual);
        }
        //Usecase 3
        [TestMethod]
        [TestCategory("PersonAgeBetween13And18")]
        public void GivenRecord_ReturnAgeRecord_Between13An18()
        {
            List<string> expected = new List<string> { "Harsha" };
            List<string> actual = personDetailManagement.PersonAgeBetween13And18();
            CollectionAssert.AreEqual(expected, actual);
        }
        //Usecase 4
        [TestMethod]
        [TestCategory("Average of Age")]
        public void ReturnAverageofAge()
        {
            double expected = 40.667;
            double actual = personDetailManagement.AverageAgeRecord();
            Assert.AreEqual(actual, expected);
        }

        //Usecase 5
        [TestMethod]
        [TestCategory("Search a Name")]
        [DataRow("Arpita","Found")]
        [DataRow("Ash","Not Found")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void SearchaValue(string searchValue,string expected)
        {
            personDetailManagement.AddPerson();
            try
            {
                string actual = personDetailManagement.SearchingSpecificName(searchValue);
                Assert.AreEqual(actual, expected);
            }
            catch(Exception ex)
            {

                Assert.AreEqual(ex.Message, expected);
            }

        }
    }
}
