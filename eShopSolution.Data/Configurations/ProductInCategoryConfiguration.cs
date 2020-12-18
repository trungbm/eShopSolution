using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            //Liên kết Loại với sản phẩm
            builder.HasKey(t => new { t.CategoryId, t.ProductId });

            builder.ToTable("ProductIncategories");

            builder.HasOne(x => x.Product).WithMany(y => y.ProductInCategories).HasForeignKey(pc => pc.ProductId);
            builder.HasOne(x => x.Category).WithMany(y => y.ProductInCategories).HasForeignKey(pc => pc.CategoryId);

        }
    }
}
