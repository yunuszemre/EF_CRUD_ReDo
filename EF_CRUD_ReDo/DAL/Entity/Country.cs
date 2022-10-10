using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Entity
{
    public class Country
    {
        public Country()
        {
            this.Cities = new List<City>();
        }
        public int CountryId { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string? CountryName { get; set; }
        public virtual List<City> Cities { get; set; }

    }
}
