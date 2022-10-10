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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(t0 => t0.CustomerId);
            builder.Property(t0 => t0.Adress).HasMaxLength(1000);
            builder.Property(t0 => t0.Password).HasMaxLength(255);
            builder.Property(t0 => t0.CustomerName).HasMaxLength(255);
            builder.Property(t0 => t0.Email).HasMaxLength(100);
            builder.Property(t0 => t0.Phone).HasMaxLength(20);
        }
    }
}
