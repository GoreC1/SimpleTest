using SimpleTest.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SimpleTest.Entities
{
    public class Option : IOption
    {
        [Required]
        public string value { get; set; }
    }
}
