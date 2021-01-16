using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public AddressRepository()
        {
        }
        /// <summary>
        /// Retrieves one address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            //Create the innstace of te Address class
            //Pass in the requested Id
            Address address = new Address(addressId);

            //Code that retrieves the deffined address

            //Temp hardcoded
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //Code that retrieves the deffined address
            //Temp hardcoded
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City =  "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146",
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // not implemented 
            return true;
        }
    }
}
