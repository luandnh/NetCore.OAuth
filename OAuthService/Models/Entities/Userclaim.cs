using System;
using System.Collections.Generic;

namespace OAuthService.Models.Entities
{
    public partial class Userclaim
    {
        public int Id { get; set; }
        public byte[] UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual User User { get; set; }
    }
}
