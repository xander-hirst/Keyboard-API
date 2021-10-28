using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class SwitchMechanism
    {
        public SwitchMechanism()
        {
            //Keyboards = new HashSet<Keyboard>();
        }

        public int Id { get; set; }
        public string Mechanism { get; set; }

        //public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
