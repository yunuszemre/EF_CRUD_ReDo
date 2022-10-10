using EF_CRUD_ReDo.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(t0 => t0.CityId);
            builder.Property(t0 => t0.CityName).HasMaxLength(255);

            builder.HasOne(t0 => t0.Country).WithMany(t1 => t1.Cities).HasForeignKey(t2 => t2.CountryId).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
