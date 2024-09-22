using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SixthCSharpPractice.ViewModel.Helper;

public class BindingHelper : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}