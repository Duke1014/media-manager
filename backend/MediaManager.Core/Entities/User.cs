using MediaManager.Core.Enums;

namespace MediaManager.Core.Entities;

public class User : BaseEntity
{
    public string Username { get; set; } = string.Empty;

}