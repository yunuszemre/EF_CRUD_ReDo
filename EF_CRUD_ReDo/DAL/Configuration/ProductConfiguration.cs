using EF_CRUD_ReDo.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t0 => t0.ProductId);
            builder.Property(t0 => t0.Description).HasMaxLength(1000);
            builder.Property(t0 => t0.ProductName).HasMaxLength(100);

            builder.HasOne(t0 => t0.Category).WithMany(t1 => t1.Products).HasForeignKey(t2 => t2.CategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
