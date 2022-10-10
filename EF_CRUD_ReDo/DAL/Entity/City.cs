using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Entity
{
    public class City
    {
        public City()
        {
            this.Districts = new List<District>();
        }
        public int CityId { get; set; }

        
        
        public string? CityName { get; set; }
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }
        public virtual List<District> Districts { get; set; }
    }
}
