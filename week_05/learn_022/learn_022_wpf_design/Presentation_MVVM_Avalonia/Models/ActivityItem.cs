using System;

namespace Presentation_MVVM_Avalonia.Models;

public class ActivityItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}