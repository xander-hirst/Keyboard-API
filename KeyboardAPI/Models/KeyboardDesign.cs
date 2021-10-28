using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyboardDesign
    {
        public KeyboardDesign()
        {
            //Keyboards = new HashSet<Keyboard>();
        }

        public int Id { get; set; }
        public string Layout { get; set; }

        //public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
