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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Carts = new HashSet<Cart>();
        }
    
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }
        public decimal PRODUCT_PRICE { get; set; }
        public string PRODUCT_REVIEW { get; set; }
        public int PRODUCT_COUNT { get; set; }
        public Nullable<System.DateTime> FIRSTMODIFIED { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public int CATEGORY_ID { get; set; }
        public Nullable<int> PRODUCTS_SOLD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual Product_Category Product_Category { get; set; }
    }
}
