using Domain.Common;

namespace Domain.Tenant
{
    public class Tenant : BaseAuditableEntity
    {
        public Profile Profile { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
