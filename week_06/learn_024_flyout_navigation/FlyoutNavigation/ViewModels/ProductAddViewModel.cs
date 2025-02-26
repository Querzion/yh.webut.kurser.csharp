using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutNavigation.ViewModels
{
    public partial class ProductAddViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Add New Product";
    }
}
