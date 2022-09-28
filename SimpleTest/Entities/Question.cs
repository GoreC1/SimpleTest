﻿using SimpleTest.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SimpleTest.Entities
{
    public class Question : IQuestion
    {
        [Required]
        public string title { get; set; }
    }
}
