using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Entity
{
    public class Order
    {
        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }
        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public int? CustomerId { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
