using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Entities.Concrate; 

namespace SocialMedia.Project.DAL.Conficurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasOne(u => u.UserDetails)
            .WithOne()
            .HasForeignKey<User>(u => u.Id);
        }
    }
}
