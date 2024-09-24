using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Repositories.Concrate
{
    public class UserDetailsRepository : BaseRepository<Post>
    {

        public UserDetailsRepository(SocialMediaDbContext context) : base(context)
        {

        }
    }
}
