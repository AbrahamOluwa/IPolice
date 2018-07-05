using System;
using System.Collections.Generic;
using System.Text;

namespace IPolice.Core.Entities
{
    public class Hospital : Contact
    {
        public string MdName { get; set; }
        public string MdImageUrl { get; set; }
        public string MdImageBlob { get; set; }
        public string MdContact { get; set; }
    }
}
