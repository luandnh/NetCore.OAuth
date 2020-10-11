using System;
using System.Collections.Generic;

namespace OAuthService.Models.Entities
{
    public partial class Userlogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public byte[] UserId { get; set; }

        public virtual User User { get; set; }
    }
}
