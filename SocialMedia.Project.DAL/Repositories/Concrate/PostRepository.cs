using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Repositories.Concrate
{
    public class PostRepository : BaseRepository<Post>
    {

        public PostRepository(SocialMediaDbContext context) : base(context)
        {

        }
    }
}
