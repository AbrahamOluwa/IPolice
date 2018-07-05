using System;
using System.Collections.Generic;
using System.Text;

namespace IPolice.Core.Entities
{
    public class ArmyBarrack : Contact
    {
        public string CommandantName { get; set; }
        public string CommandantImageUrl { get; set; }
        public string CommandantImageBlob { get; set; }
        public string CommandantContact { get; set; }
    }
}
