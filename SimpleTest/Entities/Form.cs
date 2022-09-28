using SimpleTest.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace SimpleTest.Entities
{
    public class Form : IForm
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string name { get; set; }

        public IQuestion[] questions { get; set; }
    }
}
