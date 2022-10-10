using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DTO
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }      
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Disconitued { get; set; }
        public int UnitsInStock { get; set; }

    }
}
