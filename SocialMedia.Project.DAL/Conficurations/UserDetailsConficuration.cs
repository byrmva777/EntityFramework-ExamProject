using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Configurations
{
    internal class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            
        
        }
    }
}
