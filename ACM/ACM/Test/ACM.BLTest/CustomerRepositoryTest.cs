using System;
using System.Collections.Generic;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepostory = new CustomerRespitory();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //-- Act
            var actual = customerRepostory.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.CustomerID, actual.CustomerID);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepostory = new CustomerRespitory();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144",
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146",
                    }
                }
            };

            //-- Act
            var actual = customerRepostory.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.CustomerID, actual.CustomerID);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

            }
        }

        [Fact]
        public void SaveTestValid()
        {
            //-- Arrange
            var customerRepostory = new CustomerRespitory();
            var updatedCustomer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                HasChanges = true
            };

            //-- Act
            var actual = customerRepostory.Save(updatedCustomer);

            //-- Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingName()
        {
            //-- Arrange
            var customerRepostory = new CustomerRespitory();
            var updatedCustomer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = null,
                LastName = null,
                HasChanges = true
            };

            //-- Act
            var actual = customerRepostory.Save(updatedCustomer);

            //-- Assert
            Assert.False(actual);
        }
    }
}
