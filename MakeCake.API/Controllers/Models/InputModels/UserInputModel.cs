﻿using System.ComponentModel.DataAnnotations;

namespace MakeCake.API.Controllers.Models.InputModels
{
    public class UserInputModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
