using Business_.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace learn_010_presentation_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly UserService _userService = new();

        public MainWindow()
        {
            InitializeComponent();

            _userService.Add(new Dtos_.UserRegistrationForm()
            {
                // Add something later. . .
            });
        }
    }
}