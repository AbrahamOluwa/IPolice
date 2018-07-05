using System;
using System.Collections.Generic;
using System.Text;

namespace IPolice.Core.Entities
{
    public class PoliceStation : Contact
    {
        public string DpoName { get; set; }
        public string DpoImageUrl { get; set; }
        public string DpoImageBlob { get; set; }
        public string DpoContact { get; set; }
    }
}
