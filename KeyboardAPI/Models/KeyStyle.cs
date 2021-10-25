using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyStyle
    {
        public KeyStyle()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public int KeyStyleId { get; set; }
        public string Style { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
