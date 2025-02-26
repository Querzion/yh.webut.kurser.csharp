using Avalonia.Controls;

namespace MA_Presentation_MVVM_Avalonia.Views;

public partial class UserAddView : UserControl
{
    public UserAddView()
    {
        InitializeComponent();
    }

    // private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    // {
    //     if (sender is PasswordBox passwordBox && DataContext is UserAddViewModel viewModel)
    //     {
    //         var property = passwordBox.Tag.ToString();
    //         if (property == "Password")
    //         {
    //             viewModel.User.Password = passwordBox.Password;
    //         }
    //         else if (property == "ConfirmPassword")
    //         {
    //             viewModel.User.ConfirmPassword = passwordBox.Password;
    //         }
    //     }
    // }
}