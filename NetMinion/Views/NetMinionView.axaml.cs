using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using NetMinion.ViewModels;

namespace NetMinion.Views
{
    public partial class NetMinionView : UserControl
    {

        NetMinionViewModel netMinionViewModel;
        public NetMinionView()
        {
            netMinionViewModel = new NetMinionViewModel();
            this.DataContext = netMinionViewModel;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}