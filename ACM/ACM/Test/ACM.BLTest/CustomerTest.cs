using System;
using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expect = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expect = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expect = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expect, actual);
        }
    }
}
