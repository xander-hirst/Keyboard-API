using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class MechanicalSwitch
    {
        public MechanicalSwitch()
        {
            //Keyboards = new HashSet<Keyboard>();
        }

        public string Color { get; set; }
        public string ActuationType { get; set; }
        public int ActuationForceInG { get; set; }
        public int BottomOutForceInG { get; set; }

        //public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
