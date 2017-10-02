﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSite.WebUI.Models
{
    public class ContactMe
    {
        [Required]
        [StringLength(20,MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }

    }
}