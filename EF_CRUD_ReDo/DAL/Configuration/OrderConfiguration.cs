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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(t0 => t0.OrderId);
            builder.Property(t0 => t0.OrderNumber).HasMaxLength(100);

            builder.HasOne(t0 => t0.Customer).WithMany(t1 => t1.Orders).HasForeignKey(t2 => t2.CustomerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
