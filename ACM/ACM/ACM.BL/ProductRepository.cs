using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        public ProductRepository()
        {
        }

        /// <summary>
        /// Retrive one Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined customer

            // temporary hard-coded values to return
            // a populated customer
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assoretd Size Ser of 4 Bright Yellow Min Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Save(Product product)
        {
            return true;
        }
    }
}
