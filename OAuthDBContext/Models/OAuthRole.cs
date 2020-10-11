using System;
using Microsoft.AspNetCore.Identity;

namespace OAuthDBContext.Models
{
    public class OAuthRole : IdentityRole<Guid>
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public OAuthRole() { }
    }
}