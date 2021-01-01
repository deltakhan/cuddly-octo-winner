using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRespository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assoretd Size Ser of 4 Bright Yellow Min Sunflowers",
                ProductName = "Sunflowers"
            };

            //-- Act
            var actual = productRespository.Retrieve(2);

            //--Assert
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName);
        }
    }
}
