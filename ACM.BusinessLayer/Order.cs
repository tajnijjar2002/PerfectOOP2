using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.CommonLib;

namespace ACM.BusinessLayer
{
    public class Order: EntityBase, ILoggable
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        


        

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            
            return isValid;
        }


        public override string ToString()
        {
            return this.OrderDate.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            var logString = this.OrderId + ": " +
                            "Date: " + this.OrderDate.Value.Date + " " +
                            "Status: " + this.EntityState.ToString();

            return logString;
        }
    }
}
