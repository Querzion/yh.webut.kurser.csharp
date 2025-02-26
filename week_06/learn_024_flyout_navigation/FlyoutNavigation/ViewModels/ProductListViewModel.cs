using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutNavigation.ViewModels
{
    public partial class ProductListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Overview - Product List";
    }
}
