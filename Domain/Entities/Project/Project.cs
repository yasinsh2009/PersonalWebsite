using Domain.Common;

namespace Domain.Entities.Project
{
    public class Project : BaseAuditableEntity
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public ICollection<Comment.Comment> Comments { get; set; }

        public ICollection<Image.Image> Images { get; set; }

        public long TenantId { get; set; }

        public Tenant.Tenant Tenant { get; set; }

    }
}
