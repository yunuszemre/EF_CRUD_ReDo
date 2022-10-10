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
    public class DisctrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(t0 => t0.DistrictId);

            builder.Property(t0 => t0.DistrictName).HasMaxLength(255);

            //Mahalle-Şehir =>One-To-Many ilişki
            builder.HasOne(t0 => t0.City).WithMany(t1 => t1.Districts).HasForeignKey(t2 => t2.CityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t0 => t0.Customer).WithMany(t1 => t1.Districts).HasForeignKey(t2 => t2.CustomerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
