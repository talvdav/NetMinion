using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMinion.Models
{
    public class IpListModel: List<IpModel>
    {
        //public string IpTemplate { get; set; }

        public IpListModel(){

        }
        public IpListModel(string IpTemplate)
        {
            string[] arr1 = IpTemplate.Split('/');

            string[] arr2 = arr1[0].Split('.');

            int noOfNetBits = int.Parse(arr1[1]);

            int[] sections = new int[4];
            for (int i = 0; i < 4; i++)
            {
                sections[i] = int.Parse(arr2[i]);
            }

            long maskNet = (long)Math.Pow(2, 32) - 1;
            string binaryMaskNet = Convert.ToString(maskNet, 2);

            long maskHost = (long)Math.Pow(2, 32 - noOfNetBits) - 1;
            string binaryMaskHost = Convert.ToString(maskHost, 2);

            long mask = maskNet ^ maskHost;
            string binaryMask = Convert.ToString(mask, 2);

            int ipAddr = 0;
            int mult = 1;

            for (int i = 3; i >= 0; i--)
            {

                int multSection = sections[i] * mult;

                // binary = Convert.ToString(multSection, 2);

                ipAddr += (sections[i] * mult);
                // binary = Convert.ToString(ipAddr, 2);

                mult *= 256;
            }

            long netAddr = ipAddr & mask;
            string binaryNet = Convert.ToString(netAddr, 2);


            int n = (int)Math.Pow(2, 32 - noOfNetBits);

            ulong[] sectArr = new ulong[4];
            for (int i = 0; i < n; i++)
            {
                long complIpAddr = (long)netAddr + i;

                sectArr[0] = (ulong)(complIpAddr << 24 + 32);
                sectArr[0] = sectArr[0] >> 24 + 32;

                sectArr[1] = (ulong)(complIpAddr << 16 + 32);
                sectArr[1] = sectArr[1] >> 24 + 32;

                sectArr[2] = (ulong)(complIpAddr << 8 + 32);
                sectArr[2] = sectArr[2] >> 24 + 32;

                sectArr[3] = (ulong)(complIpAddr << 32);
                sectArr[3] = sectArr[3] >> 24 + 32;

                string ipString = string.Format("{0}.{1}.{2}.{3}", sectArr[3], sectArr[2], sectArr[1], sectArr[0]);

                var ipAddress = new IpModel();
                ipAddress.IpAddress = ipString;

                this.Add(ipAddress);
            }

            long hostAddr = ipAddr & (~mask);
            string binaryHost = Convert.ToString(hostAddr, 2);
        }
    }
}
