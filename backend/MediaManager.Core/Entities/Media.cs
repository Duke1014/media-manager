using MediaManager.Core.Enums;

namespace MediaManager.Core.Entities;

public class Asset : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public MediaCategory Category { get; set; }

    public MediaCondition Condition { get; set; } = MediaCondition.Good;

    public string Location { get; set; } = string.Empty;

    public string? Platform { get; set; }

    public string? Publisher { get; set; }

    public string? ReleaseYear { get; set; }

    public decimal? EstimatedValue { get; set; }

// to be used later when we integrate AI to assist
    public string? AiAnalysis { get; set; }

    public User? UploadedBy { get; set; }

// TO-DO LATER: loan info (LoanTo(), who the loan goes to, when it was loaned)
}