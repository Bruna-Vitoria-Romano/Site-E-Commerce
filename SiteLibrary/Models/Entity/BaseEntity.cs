using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteLibrary.Models.Entity
{
    internal class BaseEntity
    {
        public BaseEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
    }
}
