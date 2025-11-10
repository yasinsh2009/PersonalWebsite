using Domain.Common;

namespace Domain.Entities.Tenant
{
    public class Tenant : BaseAuditableEntity
    {
        public long ProfileId { get; set; }
        public Profile.Profile Profile { get; set; }

        public ICollection<Project.Project> Projects { get; set; }

        public ICollection<Blog.Blog> Blogs { get; set; }
    }
}
