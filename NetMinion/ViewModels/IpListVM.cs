using System.Collections.ObjectModel;
// using NetMinion.ViewModels;

using NetMinion.Models;

namespace NetMinion.ViewModels
{
    public class IpListVM : ObservableCollection<IpModel>
    {
        public IpListModel? IpListModel { get; set;}

        public void Initialize(){
            foreach (IpModel ipModel in IpListModel) {
                var ipViewModel = new IpViewModel(ipModel);
                ipViewModel.IpAddress = ipModel.IpAddress;
                ipViewModel.HostName = ipModel.HostName;
                ipViewModel.PingStatus = ipModel.PingStatus;
                this.Add(ipViewModel);
            }
            
        }
    }
}