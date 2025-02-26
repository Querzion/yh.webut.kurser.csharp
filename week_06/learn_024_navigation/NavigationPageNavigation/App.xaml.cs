using NavigationPageNavigation.Pages;

namespace NavigationPageNavigation
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            var productListPage = _serviceProvider.GetRequiredService<ProductListPage>();
            MainPage = new NavigationPage(productListPage);
        }
    }
}
