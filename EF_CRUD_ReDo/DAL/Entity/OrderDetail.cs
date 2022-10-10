using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Entity
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Quantity { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
