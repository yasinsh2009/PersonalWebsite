using Domain.Common;

namespace Domain.Entities.Comment
{
    public class Comment : BaseAuditableEntity
    {
        public string CommentorFullName { get; set; }

        public string CommentorTagLine { get; set; }

        public string Text { get; set; }

        public int Likes { get; set; }
    }
}
