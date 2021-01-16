using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerID { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }


        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
