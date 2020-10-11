using System;
using System.Collections.Generic;

namespace OAuthService.Models.Entities
{
    public partial class Usertoken
    {
        public byte[] UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual User User { get; set; }
    }
}
