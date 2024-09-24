using SocialMedia.Project.Models.Entities.Abstract;

namespace SocialMedia.Project.Models.Entities.Concrate
{
    public class User : BaseEntity
    { 
        // Navigation property
        public UserDetails UserDetails { get; set; }
    }
}
