using System.ComponentModel.DataAnnotations;

namespace Practical_7.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter your comments")]
        [StringLength(500, ErrorMessage = "Comments cannot exceed 500 characters")]
        public string Comments { get; set; }
    }
}