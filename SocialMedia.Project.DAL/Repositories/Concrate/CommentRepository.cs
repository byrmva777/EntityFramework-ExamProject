using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Repositories.Concrate
{
    public class CommentRepository : BaseRepository<Post>
    {
    
        public CommentRepository(SocialMediaDbContext context) : base(context)
        {

        }
    }
}
