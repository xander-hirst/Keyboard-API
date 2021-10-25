using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class CherrySwitch
    {
        public CherrySwitch()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public string Color { get; set; }
        public string ActuatuationType { get; set; }
        public int ActuationForceInG { get; set; }
        public int BottomOutForceInG { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
