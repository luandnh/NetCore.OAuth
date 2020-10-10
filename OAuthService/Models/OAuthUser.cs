using System;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace OAuthService.Models
{
    public class OAuthUser : IdentityUser<Guid>
    {
        public OAuthUser()
        {
        }
    }
}
