using ReactiveUI;
using NetMinion.Models;

namespace NetMinion.ViewModels
{
    public class IpViewModel : ViewModelBase
    {
        private IpModel ipModel;

        private string ipAddress;
        public string IpAddress { 
            get => ipAddress; 
            set => this.RaiseAndSetIfChanged(ref ipAddress, value); 
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
            this.IpAddress = this.ipModel.IpAddress;
            this.HostName = this.ipModel.HostName;
            this.PingStatus = this.ipModel.PingStatus;

        }
    }
}