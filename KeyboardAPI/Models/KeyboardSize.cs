using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyboardSize
    {
        public KeyboardSize()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public int KeyboardSizeId { get; set; }
        public string Size { get; set; }
        public int NumKeys { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
