using System;
using System.ComponentModel.DataAnnotations;

namespace MangementSystemStudium.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Event date and time are required.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Event Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Venue location is required.")]
        [StringLength(150, ErrorMessage = "Venue name cannot exceed 150 characters.")]
        public string Venue { get; set; }
    }
}