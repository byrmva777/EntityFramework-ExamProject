using Microsoft.EntityFrameworkCore;
using SocialMedia.Project.Models.Entities.Concrate;
using SocialMedia.Project.DAL.Configurations;
using SocialMedia.Project.DAL.Conficurations;

public class SocialMediaDbContext : DbContext
{
    
    public DbSet<UserDetails> UserDetails { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=WINDOWS-OQKHAJ5\\MSSQLLocalDB;Initial Catalog=SocialMedia;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.ApplyConfiguration(new UserDetailsConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
