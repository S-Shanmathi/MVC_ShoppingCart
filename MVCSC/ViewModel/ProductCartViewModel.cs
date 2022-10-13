using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ShoppingCart.ViewModel
{
    public class ProductCartViewModel
    {
        public string PRODUCT_ID { get; set; }

        public string PRODUCT_NAME { get; set; }
        public decimal PRODUCT_COUNT { get; set; }
        public string PRODUCT_TOTALPRICE { get; set; }
    }
}