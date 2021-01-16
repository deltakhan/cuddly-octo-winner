using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable

    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderID = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int OrderID { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        

        /// <summary>
        /// VAlidates Order
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderID})";

        public string Log() => $"{OrderID}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState}";
    }
}
