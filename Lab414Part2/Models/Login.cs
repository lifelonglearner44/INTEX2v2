﻿using System.ComponentModel.DataAnnotations;

namespace INTEX2v2.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public bool Remember { get; set; }
    }
}
