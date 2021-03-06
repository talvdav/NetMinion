
namespace NetMinion.Models
{
    public class IpModel
    {
    
        public string IpAddress;
        public string HostName; 
        public string PingStatus; 

        public IpModel( )
        {
            this.IpAddress = string.Empty;
            this.HostName = string.Empty;
            this.PingStatus = string.Empty;
        }

        public IpModel( string ipAddress, string hostName, string pingStatus )
        {
            this.IpAddress = ipAddress;
            this.HostName = hostName;
            this.PingStatus = pingStatus;
        }

    }
}