using Domains;
using Microsoft.AspNetCore.Identity;

namespace Magazine.User
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
       
        public byte[]?Cover { get; set; }
    }
}
