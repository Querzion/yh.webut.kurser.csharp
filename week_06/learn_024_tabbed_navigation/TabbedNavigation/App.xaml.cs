using TabbedNavigation.Tabs;

namespace TabbedNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPages();
        }
    }
}
