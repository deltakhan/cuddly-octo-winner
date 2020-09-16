using System;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem( int orderItemId)
        {
            OrderItemID = orderItemId;
        }

        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }


        /// <summary>
        /// Saves an OrderItem
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates OrderItem
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
    }
}
