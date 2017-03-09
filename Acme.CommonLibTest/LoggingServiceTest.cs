using System;
using System.Collections.Generic;
using Acme.CommonLib;
using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonLibTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "abc@abc.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };

            changedItems.Add(customer as ILoggable);


            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);




            //Act
            LoggingService.WriteToFile(changedItems);


            //Assert
            //Nothing here to assert.
        }
    }
}
