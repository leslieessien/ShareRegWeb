using Microsoft.AspNetCore.Identity;

using System.Numerics;

namespace ShareRegWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public string Branch { get; set; }
        
    }
}
