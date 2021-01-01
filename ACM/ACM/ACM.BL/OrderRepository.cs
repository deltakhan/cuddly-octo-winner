using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderRepository()
        {
        }

       /// <summary>
       /// Retrieve one order
       /// </summary>
       /// <param name="orderId"></param>
       /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined customer

            // temporary hard-coded values to return
            // a populated customer
            if (orderId == 10)
            {
                //Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                     new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Saves an order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
