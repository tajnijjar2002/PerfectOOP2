using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class OrderItem
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }





        ///<summary>
        ///Retrieve list of customers 
        ///</summary>
        public List<OrderItem> Retrieve()
        {
            //TODO -- code to retrieve list. 

            return new List<OrderItem>();
        }


        ///<summary>
        ///Retrieve one customer. 
        ///</summary>
        public OrderItem Retrieve(int orderItemId)
        {
            //TODO -- code to retrieve the defined customer
            return new OrderItem();
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

        public bool Validate()
        {
            bool isValid = true;

            if (OrderQuantity <= 0)
            {
                isValid = false;
            }

            if (ProductId <= 0)
            {
                isValid = false;
            }

            if (PurchasePrice <= 0)
            {
                isValid = false;
            }
            
            return isValid;
        }

    }
}
