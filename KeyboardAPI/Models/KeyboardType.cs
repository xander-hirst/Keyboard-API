using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyboardType
    {
        public KeyboardType()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
