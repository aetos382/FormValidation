namespace FormValidation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class PostModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
