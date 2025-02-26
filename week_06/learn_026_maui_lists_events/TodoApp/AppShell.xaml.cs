using TodoApp.MVVM.Views;
using ListView = TodoApp.MVVM.Views.ListView;

namespace TodoApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ListView), typeof(ListView));
            Routing.RegisterRoute(nameof(AddView), typeof(AddView));
            Routing.RegisterRoute(nameof(EditView), typeof(EditView));
        }
    }
}
