using System;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRespitory
    {
        public CustomerRespitory()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerid"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerid)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerid);

            // Code that retrieves the defined customer

            // temporary hard-coded values to return
            // a populated customer
            if (customerid == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerid).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed customer

            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Call an insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Proc
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
