using System.Collections.ObjectModel;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> _items = [];

        public MainPage()
        {
            InitializeComponent();
            List_NameList.ItemsSource = _items;
            Collection_NameList.ItemsSource = _items;
        }

        private void Button_Add_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Entry_Name.Text))
            {
                _items.Add(Entry_Name.Text);
                Entry_Name.Text = string.Empty;
            }
        }
    }

}
