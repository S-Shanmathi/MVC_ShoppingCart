//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCSC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public int PRODUCT_COUNT { get; set; }
        public decimal PRODUCT_TOTALPRICE { get; set; }
        public int CART_ID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}