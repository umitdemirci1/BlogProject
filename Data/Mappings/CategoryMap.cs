using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("9868F285-D7B9-4B5E-83E9-8FAA1D11DDFC"),
                Name = "Category 1",
                CreatedBy = "Admin 3",
                CreatedDate = new DateTime()
            },
            new Category
            {
                Id = Guid.Parse("305DC2E9-CADD-44A7-8A8A-615D7212BEA9"),
                Name = "Category 1",
                CreatedBy = "Admin 3",
                CreatedDate = new DateTime()
            });
        }
    }
}
