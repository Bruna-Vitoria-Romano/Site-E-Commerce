using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteLibrary.Models.Entity
{
    internal class User : BaseEntity
    {
        public User(int id, string name, string email, string password) : base(id, name)
        {
            Email = email;
            Password = password;
        }

        protected string Email { get; set; }
        protected string Password { get; set; }
    }
}
