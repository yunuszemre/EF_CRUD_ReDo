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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(t0 => t0.OrderDetailId);

            builder.HasOne(t0 => t0.Order).WithMany(t1 => t1.OrderDetails).HasForeignKey(t2 => t2.OrderId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t0 => t0.Product).WithMany(t1 => t1.OrderDetails).HasForeignKey(t2 => t2.ProductId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
