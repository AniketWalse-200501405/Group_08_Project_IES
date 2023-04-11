using Microsoft.AspNetCore.Identity;

namespace Group_8_Final_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
