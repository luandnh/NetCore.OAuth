using System;
using System.Collections.Generic;

namespace OAuthService.Models.Entities
{
    public partial class Roleclaim
    {
        public int Id { get; set; }
        public byte[] RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Role Role { get; set; }
    }
}
