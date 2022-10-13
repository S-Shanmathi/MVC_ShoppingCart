using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_ShoppingCart.Models
{
    public class Product_Category
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CATEGORY_ID { get; set; }

        public string CATEGORY_NAME { get; set; }

        public DateTime FIRSTMODIFIED { get; set; }
        public DateTime LASTMODIFIED { get; set; }
    }
}