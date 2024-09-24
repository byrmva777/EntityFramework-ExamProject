using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Repositories.Concrate
{
    public class UserRepository : BaseRepository<Post>
    {
        public UserRepository(SocialMediaDbContext context) : base(context)
        {

        }
    }
}

