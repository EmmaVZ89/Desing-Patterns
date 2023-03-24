using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Repository.Models
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public Guid BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
