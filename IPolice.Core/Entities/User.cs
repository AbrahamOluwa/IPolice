using System;
using System.Collections.Generic;
using System.Text;

namespace IPolice.Core.Entities
{
    public class User : Contact
    {
        public Location Location { get; set; }
        public TrackMe TrackMe { get; set; }
    }
}
