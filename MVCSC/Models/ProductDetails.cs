using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ShoppingCart.Models
{
    public class ProductDetails
    {
        //[Key, Column(Order = 1)]
        // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int PRODUCT_ID { get; set; }

        public string PRODUCT_NAME { get; set; }

        public string PRODUCT_DESCRIPTION { get; set; }
        public decimal PRODUCT_PRICE { get; set; }
        public string PRODUCT_REVIEW { get; set; }
        public int PRODUCT_SOLD { get; set; }

        //public DateTime FIRSTMODIFIED { get; set; }
        //public DateTime LASTMODIFIED { get; set; }

        public int CATEGORY_ID { get; set; }

        public String CATEGORY_NAME { get; set; }
    }
}