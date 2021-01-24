using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.Models
{
    public abstract class UserBase
    {
        public virtual long Id { get; set; }
        public virtual bool IsActive { get; set; }      
        public virtual DateTime? ModificationTime { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual string Avatar { get; set; }       
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string NickName { get; set; }
        public virtual string Password { get; set; }
        public virtual string RegisterNumber { get; set; }
       
        public virtual bool IsEmailVerification { get; set; }
    }
}
