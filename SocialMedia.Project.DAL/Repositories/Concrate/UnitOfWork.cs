using SocialMedia.Project.DAL.Repositories.Abstract;
using SocialMedia.Project.Models.Entities.Concrate;

namespace SocialMedia.Project.DAL.Repositories.Concrate
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly SocialMediaDbContext _context;
        public IRepository<User> Users { get; set; }
        public IRepository<Comment> Comments { get; set; }
        public IRepository<Post> Posts { get; set; }
        public IRepository<UserDetails> UserDetails { get; set; }

        public UnitOfWork(SocialMediaDbContext context)
        {
            _context = context;
            Posts = new BaseRepository<Post>(_context);
            Comments = new BaseRepository<Comment>(_context);
            Users = new BaseRepository<User>(_context);
            UserDetails = new BaseRepository<UserDetails>(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
