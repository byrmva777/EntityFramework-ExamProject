using SocialMedia.Project.Models.Entities.Abstract;
using System.Xml.Linq;

namespace SocialMedia.Project.Models.Entities.Concrate
{
    public class Post : BaseEntity
    {
        public string Text { get; set; }
        public int LikeCount { get; set; }

        // Navigation property 
        public ICollection<Comment> Comments { get; set; }
    }

}
