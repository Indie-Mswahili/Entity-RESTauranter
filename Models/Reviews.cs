using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [Display(Name="Reviewer Name:")]
        public string ReviewName { get; set; }

        [Required]
        [Display(Name="Restaurant Name:")]
        public string ResName { get; set; }

        [Required]
        [MinLength(10)]
        [Display(Name="Review:")]
        public string UserReview { get; set; }

        [Required]
        public int Stars { get; set; }

        [Required]
        [Display(Name="Date Of Visit:")]
        [DataType(DataType.Date)]
        public DateTime DateOfVisit { get; set; }
        
        public Reviews()
        {
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
        }
        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

    }
}