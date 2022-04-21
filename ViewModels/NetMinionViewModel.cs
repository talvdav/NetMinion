
using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;

namespace NetMinion.ViewModels
{
    public class NetMinionViewModel : ViewModelBase
    {
        public IpListViewModel IpListViewModel { get; set; }
//         public ListCollectionView IpListView { get; set; }

        public NetMinionViewModel()
        {
            IpListViewModel = new IpListViewModel();
//            IpListView = new ListCollectionView(IpListViewModel);
        }


        private string message = string.Empty;
        public string Message {
            get => message;
            set => this.RaiseAndSetIfChanged(ref message, value);
        }

        public void CommandPingAll() {
            string qqq = message;            

            // this.Message = "Hallo ich bin Command Ping ALL"; 
        }

    }
}