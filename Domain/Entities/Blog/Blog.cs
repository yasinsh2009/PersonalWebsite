using Domain.Common;

namespace Domain.Entities.Blog
{
    public class Blog : BaseAuditableEntity
    {
        public string Title { get; set; }

        public string ReadingTime { get; set; }

        public string Text { get; set; }

        public ICollection<Comment.Comment> Comments { get; set; }

        public string ImageUrl { get; set; }

        public long TenantId { get; set; }

        public Tenant.Tenant Tenant { get; set; }
    }
}
