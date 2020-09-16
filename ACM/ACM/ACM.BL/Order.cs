using System;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderID = orderId;
        }

        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }


        /// <summary>
        /// Saves an Order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// VAlidates Order
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

    }
}
