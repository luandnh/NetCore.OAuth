using System;
using System.Collections.Generic;

namespace OAuthService.Models.Entities
{
    public partial class Userrole
    {
        public byte[] UserId { get; set; }
        public byte[] RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
