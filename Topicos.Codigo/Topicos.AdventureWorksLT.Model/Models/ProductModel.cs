using System;
using System.Collections.Generic;

namespace Topicos.AdventureWorksLT.Model.Models
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }

        public int ProductModelId { get; set; }
        public string Name { get; set; } = null!;
        public string? CatalogDescription { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
