using ReactiveUI;
using NetMinion.Models;

namespace NetMinion.ViewModels
{
    public class IpViewModel : ViewModelBase
    {
        private IpModel ipModel;


        // private string ipAddress =  string.Empty; 
        public string IpAddress { 
            get => ipModel.IpAddress; 
            set => this.RaiseAndSetIfChanged(ref ipModel.IpAddress, value); 
        }
        public string HostName { get; set; } 
        public string PingStatus { get; set; }

        public IpViewModel( IpModel ipModel)
        {
            this.ipModel = ipModel;
        }
    }
}