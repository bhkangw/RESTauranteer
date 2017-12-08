using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranteer.Models
{
    public class Review : BaseEntity
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [Display(Name = "Reviewer Name")]
        [MinLength(1)]
        public string ReviewerName { get; set; }

        [Required]
        [Display(Name = "Restaurant Name")]
        [MinLength(1)]
        public string RestaurantName { get; set; }

        [Required]
        [Display(Name = "Review")]
        [MinLength(10)]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Stars")]
        public int Rating { get; set; }

        [Required]
        [Display(Name = "Date of Visit")]
        [MyDate(ErrorMessage = "Invalid date")]
        public DateTime DateOfVisit { get; set; }
    }

    public class MyDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime d = Convert.ToDateTime(value);
            return d <= DateTime.Now;

        }
    }
}