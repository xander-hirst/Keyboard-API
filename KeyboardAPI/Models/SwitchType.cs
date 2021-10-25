using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class SwitchType
    {
        public SwitchType()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public int SwitchTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
