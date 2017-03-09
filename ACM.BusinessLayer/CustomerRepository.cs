using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class CustomerRepository
    {

        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }


        ///<summary>
        ///Retrieve one customer. 
        ///</summary>
        public Customer Retrieve(int customerId)
        {
            //Create the instance of customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();


            //Code that retrieves the defined customer

            //Temporary hard coded values to return
            //a populated customer
            if (customerId == 1)
            {
                
                customer.EmailAddress = "abc@abc.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                
            }

            return customer;
        }


        ///<summary>
        ///Retrieve list of customers 
        ///</summary>
        public List<Customer> Retrieve()
        {
            //TODO -- code to retrieve list. 

            return new List<Customer>();
        }

        /// <summary>
        /// Save the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //TODO -- code that saves the defined customer.
            return true;
        }

        
    }
}
