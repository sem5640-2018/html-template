using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AberFitnessLayout.Models
{
    public class AppLink
    {
        public AppLink()
        {
            SubLinks = new List<AppSubLink>();
        }

        [Required]
        public virtual string DisplayName { get; set; }

        [Required]
        public virtual Uri Uri { get; set; }

        [Required]
        public virtual IList<AppSubLink> SubLinks { get; set; }

        [Required]
        public virtual AppLinkAccessLevel AccessLevel { get; set; }
    }
}
