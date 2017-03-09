using System;
using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BusinessLayerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            
            customer.LastName = "Baggins";

            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount++;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true;
            
            //Act
            var actual = customer.Validate();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer();
            
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            //Act
            var actual = customer.Validate();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
