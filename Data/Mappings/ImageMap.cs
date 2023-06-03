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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("5A77421E-A2E0-461E-9D83-BE79CC0F353B"),
                FileName = "images/testImage1",
                FileType = "jpg",
                CreatedBy = "Admin1",
                CreatedDate = DateTime.Now,
            },
            new Image
            {
                Id = Guid.Parse("03C51E94-26DA-479D-8964-E4EA95B2769C"),
                FileName = "images/testImage2",
                FileType = "jpg",
                CreatedBy = "Admin2",
                CreatedDate = DateTime.Now,
            }
            );
        }
    }
}
