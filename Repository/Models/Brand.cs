using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Repository.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Beer = new HashSet<Beer>();
        }

        public Guid BrandId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Beer> Beer { get; set; }
    }
}
