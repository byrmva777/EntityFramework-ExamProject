using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Conficurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {

        builder.HasMany(c => c.Comments)
            .WithOne();

    }
}
