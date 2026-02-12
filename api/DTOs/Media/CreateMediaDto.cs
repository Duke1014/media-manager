using System.ComponentModel.DataAnnotations;
using api.Models;

namespace api.DTOs.Media
{
    public class CreateMediaDto
    {
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description

        [Required]
        public MediaCategory Category { get; set; }
        
        [Required]
        public MediaCondition Condition { get; set; }

        [StringLength(100)]
        public string? Platform { get; set; }

        [StringLength(100)]
        public string? Publisher { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [Range(1800, 2100)]
        public int? ReleaseYear { get; set; }

        [Range(0, 99999.99)]
        public decimal? EstimatedValue { get; set; }

    }
}