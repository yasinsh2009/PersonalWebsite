using Domain.Common;

namespace Domain.Entities.Profile
{
    public class Profile : BaseAuditableEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TagLine { get; set; }

        public string About { get; set; }

        public string AvatarUrl { get; set; }

        public long TenantId { get; set; }

        public Tenant.Tenant Tenant { get; set; }
    }
}
