﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.CustomModels
{
    public class LoginModel
    {
        public string? UserKey { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage = "*Email ID is required")]
        public string? EmailId { get; set; }
        [Required(ErrorMessage = "*Password is required")]
        public string? Password { get; set; }
    }
}
