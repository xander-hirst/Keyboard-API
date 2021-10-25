using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class ConnectionType
    {
        public ConnectionType()
        {
            Keyboards = new HashSet<Keyboard>();
        }

        public int ConnectionTypeId { get; set; }
        public string Type { get; set; }
        public bool HasUsb { get; set; }
        public bool IsWireless { get; set; }

        public virtual ICollection<Keyboard> Keyboards { get; set; }
    }
}
