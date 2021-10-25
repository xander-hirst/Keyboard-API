using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
