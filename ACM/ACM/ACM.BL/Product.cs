using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductID = productId;
        }

        public int ProductID { get; private set; }
        private string _productName;
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }

            set
            {
                _productName = value;
            }
        }

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
        public string Log() => $"{ProductID}: {ProductID} Deatil: {ProductDescription} Status: {EntityState}";
    }
}
