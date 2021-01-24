using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.Interfaces.Class
{
    interface IUserBase
    {
        public long Id { get; set; }
        public string Avatar { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifyDate { get; set; }
    }
}
