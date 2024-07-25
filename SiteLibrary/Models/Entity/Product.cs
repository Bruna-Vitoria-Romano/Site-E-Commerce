using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteLibrary.Models.Entity
{
    internal class Product : BaseEntity
    {
        public Product(int id, string name, double price, Enum status, string description) : base(id, name)
        {
            Price = price;
            Status = status;
            Description = description;
        }

        protected double Price { get; set; }
        protected Enum Status { get; set; }
        protected string Description { get; set; }
    }
}
