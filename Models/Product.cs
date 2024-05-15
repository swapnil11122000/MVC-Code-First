using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name Required")]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Quantity is required")]
        public int Qty { get; set; }
        [Required(ErrorMessage ="Price is required")]
        public int Price { get; set; }

        public string Remarks { get; set; }
    }

    public class EFCodeFirstEntities : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}