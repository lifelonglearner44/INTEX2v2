using Microsoft.AspNetCore.Identity;

namespace INTEX2v2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
