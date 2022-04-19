
namespace NetMinion.Models
{
    public class Host
    {
        public string IpAddress { get; set; }
        public string HostName { get; set; } 
        public string PingStatus { get; set; }

        public Host()
        {
            this.IpAddress = "";
            this.HostName = "";
            this.PingStatus = "";
        }
    }
}