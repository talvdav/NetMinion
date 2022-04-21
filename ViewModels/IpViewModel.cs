using ReactiveUI;
using NetMinion.Models;

namespace NetMinion.ViewModels
{
    public class IpViewModel : ViewModelBase
    {
        private IpModel ipModel;

        public string IpAddress { 
            get => ipModel.IpAddress; 
            set => this.RaiseAndSetIfChanged(ref ipModel.IpAddress, value); 
        }
        public string HostName { 
            get => ipModel.HostName; 
            set => this.RaiseAndSetIfChanged(ref ipModel.HostName, value); 
        } 
        public string PingStatus { 
            get => ipModel.PingStatus; 
            set => this.RaiseAndSetIfChanged(ref ipModel.PingStatus, value); 
        }

        public IpViewModel( IpModel ipModel)
        {
            this.ipModel = ipModel;
        }
    }
}