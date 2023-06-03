using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150);

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "First Title",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                ViewCount = 12,
                CategoryId = Guid.Parse("9868F285-D7B9-4B5E-83E9-8FAA1D11DDFC"),
                ImageId = Guid.Parse("5A77421E-A2E0-461E-9D83-BE79CC0F353B"),
                CreatedBy = "Admin 1",
                CreatedDate = DateTime.Now,
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Second Title",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ante metus dictum at tempor commodo ullamcorper a lacus. Sapien pellentesque habitant morbi tristique. Amet facilisis magna etiam tempor orci eu lobortis. Velit dignissim sodales ut eu sem integer vitae. Orci dapibus ultrices in iaculis nunc sed. Vitae congue eu consequat ac felis donec et odio pellentesque. Sed odio morbi quis commodo. Ante in nibh mauris cursus mattis molestie a iaculis at. Fermentum et sollicitudin ac orci phasellus egestas. Ut placerat orci nulla pellentesque dignissim. Amet est placerat in egestas erat. Mauris augue neque gravida in fermentum. In arcu cursus euismod quis viverra nibh cras.",
                ViewCount = 8,
                CategoryId = Guid.Parse("305DC2E9-CADD-44A7-8A8A-615D7212BEA9"),
                ImageId = Guid.Parse("03C51E94-26DA-479D-8964-E4EA95B2769C"),
                CreatedBy = "Admin 2",
                CreatedDate = DateTime.Now,
            });
        }
    }
}
