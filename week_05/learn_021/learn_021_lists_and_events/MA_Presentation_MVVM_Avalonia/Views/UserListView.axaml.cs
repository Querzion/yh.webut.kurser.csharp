using Avalonia.Controls;

namespace MA_Presentation_MVVM_Avalonia.Views;

public partial class UserListView : UserControl
{
    public UserListView()
    {
        InitializeComponent();
        // DataContext = ((App)App.Current).Services.GetRequiredService<UserListViewModel>();
        // DataContext = ((App)Application.Current!).Services.GetRequiredService<UserListViewModel>();
        
        // DataContext = App.Current.Services.GetRequiredService<UserListViewModel>();
        
        // var userService = new IUserService(); // Replace with your IUserService implementation
        // var serviceProvider = new IServiceProvider(); // Replace with your IServiceProvider implementation
        //
        // DataContext = new UserListViewModel(userService, serviceProvider);
    }
}