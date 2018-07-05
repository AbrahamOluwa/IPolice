using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IPolice.Core.Entities
{
    public enum Severity
    {
        mild, small, medium, big, intense
    }

    public class Notification
    {
        public Guid ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Title should start with Uppercase")]
        public string Title { get; set; }

        public string Description { get; set; }

        public Severity Severity { get; set; }
    }
}
