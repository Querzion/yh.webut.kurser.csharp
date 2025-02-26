using ShellNavigation.Pages;

namespace ShellNavigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProductListPage), typeof(ProductListPage));
            Routing.RegisterRoute(nameof(ProductAddPage), typeof(ProductAddPage));
        }
    }
}
