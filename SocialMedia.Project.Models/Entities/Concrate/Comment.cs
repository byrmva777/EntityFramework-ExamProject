using SocialMedia.Project.Models.Entities.Abstract;

namespace SocialMedia.Project.Models.Entities.Concrate
    
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }
        public int LikeCount { get; set; }
        public List<Comment> Comments { get; set; }

        // Foreign key 
        public int PostId { get; set; }
    }
}
