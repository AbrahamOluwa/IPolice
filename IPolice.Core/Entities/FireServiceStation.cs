using System;
using System.Collections.Generic;
using System.Text;

namespace IPolice.Core.Entities
{
    public class FireServiceStation : Contact
    {
        public string HodName { get; set; }
        public string HodImageUrl { get; set; }
        public string HodImageBlob { get; set; }
        public string HodContact { get; set; }
    }
}
