using System;
using System.ComponentModel.DataAnnotations;

namespace MangementSystemStudium.Models
{
    public class TicketBooking
    {
        public int Id { get; set; }

        // Links the booking to a specific stadium event
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        [Required(ErrorMessage = "Customer name is required.")]
        [Display(Name = "Your Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Please specify how many seats you want.")]
        [Range(1, 10, ErrorMessage = "You can book between 1 and 10 seats.")]
        [Display(Name = "Number of Seats")]
        public int SeatCount { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}