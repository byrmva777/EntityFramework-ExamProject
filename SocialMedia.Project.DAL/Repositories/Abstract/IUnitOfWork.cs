using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Repositories.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Post> Posts { get; }
        IRepository<Comment> Comments { get; }
        IRepository<User> Users { get; }
        IRepository<UserDetails> UserDetails { get; }

        int Complete();
    }
}
