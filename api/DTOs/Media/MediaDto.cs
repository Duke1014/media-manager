using api.Models;

namespace api.DTOs.Media
{
    public class MediaDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public MediaCategory Category { get; set; }
        public MediaCondition Condition { get; set; }
        public string? Platform { get; set; }
        public string? Publisher { get; set; }
        public string? Location { get; set; }
        public int? ReleaseYear { get; set; }
        public decimal? EstimatedValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; } = string.empty
    }
}