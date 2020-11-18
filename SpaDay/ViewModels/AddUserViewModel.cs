﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords do not match.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "VerifyPassword required!")]
        public string VerifyPassword { get; set; }

        public AddUserViewModel()
        {
        }
    }
}
