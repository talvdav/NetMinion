using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using NetMinion.ViewModels;

namespace NetMinion.Views
{
    public partial class IpListView : UserControl
    {

        IpListViewModel ipListViewModel;
        public IpListView()
        {
            ipListViewModel = new IpListViewModel();
            this.DataContext = ipListViewModel;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}