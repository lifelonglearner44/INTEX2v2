using Microsoft.AspNetCore.Identity;

namespace INTEX2v2.Models
{
    public class ApplicationRole : IdentityRole
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
