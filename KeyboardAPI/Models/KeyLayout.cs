using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyLayout
    {
        public KeyLayout()
        {
            /*Keyboards = new HashSet<Keyboard>();*/
        }

        public int Id { get; set; }
        public string Style { get; set; }

        //public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
