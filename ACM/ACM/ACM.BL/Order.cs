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
        /// VAlidates Order
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
