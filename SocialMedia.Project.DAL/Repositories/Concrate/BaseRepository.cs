using Microsoft.EntityFrameworkCore;
using SocialMedia.Project.DAL.Repositories.Abstract;
using SocialMedia.Project.Models.Entities.Abstract;

namespace SocialMedia.Project.DAL.Repositories.Concrate
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly SocialMediaDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(SocialMediaDbContext context)
        {
            _context = new SocialMediaDbContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            entity.CreatedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = _dbSet.FirstOrDefault(e => e.Id == Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
            }
            else
                throw new NullReferenceException();
            _context.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.Where(t => t.IsDeleted == false).ToList();
        }

        public T GetById(int Id)
        {
            return _dbSet.FirstOrDefault(t => t.Id == Id && t.IsDeleted == false);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(int Id)
        {
            var entity = _dbSet.FirstOrDefault(t => t.Id == Id);
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}