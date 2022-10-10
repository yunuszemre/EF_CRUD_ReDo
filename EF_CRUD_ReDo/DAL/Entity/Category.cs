using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Entity
{
    public class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
