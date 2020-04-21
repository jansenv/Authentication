﻿using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}