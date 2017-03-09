using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class ProductRepository
    {



        ///<summary>
        ///Retrieve list of customers 
        ///</summary>
        public List<Product> Retrieve()
        {
            //TODO -- code to retrieve list. 

            return new List<Product>();
        }


        ///<summary>
        ///Retrieve one customer. 
        ///</summary>
        public Product Retrieve(int productId)
        {
            
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }


        /// <summary>
        /// Save the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //call insert store procedure
                }
                else
                {
                    //call update store procedure
                }
            }


            return success;
        }
    }
}
