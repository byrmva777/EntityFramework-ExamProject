using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Conficurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {

            builder.HasMany(p => p.Comments).WithOne();

        }
    }
}
