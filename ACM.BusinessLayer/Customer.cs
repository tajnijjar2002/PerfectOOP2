 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
 using Acme.CommonLib;
 using ACM.BusinessLayer;

namespace ACM.BusinessLayer
{
    public class Customer: EntityBase, ILoggable
    {
        public Customer():this(0)
        {
            
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;

            //This is done to initialize the list to some default
            //  value. The reason is that by default List<>s in C#
            //  are initialized to NULL by default, which can lead
            //  to "null value exception" when we try to access the
            //  the value of the list.
            //This will set the value of "AddressList" to an empty
            //  list instead of NULL.
            //IT IS A MUST TO INITIALIZE LIST IN CONSTRUCTOR.
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }
        public int CustomerType { get; set; }
        

        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }
        //OR we can have a list of addresses, as:
        public List<Address> AddressList { get; set; }



        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(FirstName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
                
            }
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return this.FullName;
        }


        public string Log()
        {
            var logString = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.EmailAddress + " " +
                            "Status: " + this.EntityState.ToString();

            return logString;
            
        }

    }
}