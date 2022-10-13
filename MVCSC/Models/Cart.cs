using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ShoppingCart.Models
{
    public class Cart
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CART_ID { get; set; }

        public string PRODUCT_ID { get; set; }

        public string PRODUCT_NAME { get; set; }
        public decimal PRODUCT_COUNT { get; set; }
        public string PRODUCT_TOTALPRICE { get; set; }


    }
}