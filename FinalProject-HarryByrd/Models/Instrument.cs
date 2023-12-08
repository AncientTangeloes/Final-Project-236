using Microsoft.AspNetCore.Authentication;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_HarryByrd.Models
{
    public class Instrument
    {
        public int InstrumentId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        public string? Year { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter a category.")]
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
