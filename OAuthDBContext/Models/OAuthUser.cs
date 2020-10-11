using System;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace OAuthDBContext.Models
{
    public class OAuthUser : IdentityUser<Guid>
    {
        public OAuthUser()
        {
        }
    }
}
