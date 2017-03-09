using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.CommonLib;

namespace ACM.BusinessLayer
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }


        public int  ProductId { get; private set; }
        public Decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }

        private string _ProductName;

        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
                //return StringHandler.InsertSpaces(_ProductName);
            }
            set { _ProductName = value; }
        }
        




        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }


        public override string ToString()
        {
            return this.ProductName;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Details: " + this.ProductDescription+ " " +
                            "Status: " + this.EntityState.ToString();

            return logString;

        }


    }
}
