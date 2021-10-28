using System;
using System.Collections.Generic;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class Keyboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool HasBacklighting { get; set; }
        public int KeyLayoutId { get; set; }
        public int KeyboardDesignId { get; set; }
        public int KeyboardSizeId { get; set; }
        public int SwitchMechanismId { get; set; }
        public string MechanicalSwitchColor { get; set; }
        public int ConnectionTypeId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ConnectionType ConnectionType { get; set; }
        public virtual KeyLayout KeyLayout { get; set; }
        public virtual KeyboardDesign KeyboardDesign { get; set; }
        public virtual KeyboardSize KeyboardSize { get; set; }
        public virtual MechanicalSwitch MechanicalSwitchColorNavigation { get; set; }
        public virtual SwitchMechanism SwitchMechanism { get; set; }
    }
}
