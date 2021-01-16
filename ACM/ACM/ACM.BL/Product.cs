using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductID = productId;
        }

        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Validates Product Data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;
    }
}
