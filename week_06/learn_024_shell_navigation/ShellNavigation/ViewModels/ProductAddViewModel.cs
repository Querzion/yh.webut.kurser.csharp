using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellNavigation.ViewModels
{
    public partial class ProductAddViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateToList()
        {
            await Shell.Current.GoToAsync("ProductListPage");
        }
    }
}
