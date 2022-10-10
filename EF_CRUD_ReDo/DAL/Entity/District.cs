using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Entity
{
    public  class District
    {
        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public virtual City City { get; set; }
        public int? CityId { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
