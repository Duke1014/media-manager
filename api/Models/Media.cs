using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Media
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; } = string.Empty;

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

        [Column(TypeName = "decimal(18,2)")]
        public decimal? EstimatedValue { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // user that created this media entry, later we set an 'owner' to the media
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
    }
}