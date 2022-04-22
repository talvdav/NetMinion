
namespace NetMinion.Models
{
    public class IpViewModel
    {
        public string IpAddress { get; set; }
        public string HostName { get; set; } 
        public string PingStatus { get; set; }

        public IpViewModel()
        {
            this.IpAddress = "";
            this.HostName = "";
            this.PingStatus = "";
        }
    }
}