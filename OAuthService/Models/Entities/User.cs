using System;
using System.Collections.Generic;

namespace OAuthService.Models.Entities
{
    public partial class User
    {
        public User()
        {
            Userclaim = new HashSet<Userclaim>();
            Userlogin = new HashSet<Userlogin>();
            Userrole = new HashSet<Userrole>();
            Usertoken = new HashSet<Usertoken>();
        }

        public byte[] Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public short EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public short PhoneNumberConfirmed { get; set; }
        public short TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public short LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<Userclaim> Userclaim { get; set; }
        public virtual ICollection<Userlogin> Userlogin { get; set; }
        public virtual ICollection<Userrole> Userrole { get; set; }
        public virtual ICollection<Usertoken> Usertoken { get; set; }
    }
}
