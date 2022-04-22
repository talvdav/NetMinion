
using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;

using NetMinion.Models;

namespace NetMinion.ViewModels
{

    public class NetMinionViewModel : ViewModelBase
    {
        public IpListVM IpListViewModel { get; set; }
//         public ListCollectionView IpListView { get; set; }

        public NetMinionViewModel()
        {
            IpListViewModel = new IpListVM();
//            IpListView = new ListCollectionView(IpListViewModel);
        }


        private string message = string.Empty;
        public string Message {
            get => message;
            set => this.RaiseAndSetIfChanged(ref message, value);
        }


        private void InitializeIpList()
        {
                   
            var ipListModel = new IpListModel("10.0.0.0/24");  

            foreach(IpModel ipModel in ipListModel)
            {
               IpListViewModel.Add(ipModel);     

            }




//            IpListViewModel.IpListModel = ipListModel;     
//            IpListViewModel.Initialize();
        }

        public void CommandPingAll() {
            // string qqq = message;            
            // this.Message = "Hallo ich bin Command Ping ALL"; 

            InitializeIpList();
        }

    }
}