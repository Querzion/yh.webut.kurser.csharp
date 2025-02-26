using System.ComponentModel;

namespace Business.Models;

public class ActivityItem : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    
    public string? Activity { get; set; }

    private bool _isCompleted;

    public bool IsCompleted
    {
        get => _isCompleted;
        set
        {
            if (_isCompleted != value)
            {
                _isCompleted = value;
                // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCompleted)));
                OnPropertyChanged(nameof(IsCompleted));
            }
        }
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}