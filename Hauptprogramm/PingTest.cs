using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using vseUtilities;

namespace Hauptprogramm
{
    public class PingTest
    {
        public static void Ping()
        {
            // Set some variables for later usage
            string ipAddressOfVse = "10.30.160.211";
            short portOfVse = 3321;
            /* var result = ICore.checkInstanceValidity();
            if (!result.isOk())
            {
                Console.WriteLine("Error " + result.text());
                return;
            }
            var vse = new IVse();
            vse.connect(ipAddressOfVse, portOfVse);
            Console.WriteLine("Device Type: " + vse.deviceType());
            Console.WriteLine("Read Parameters: " + vse.readParameters());
            */
            // Try
            // Nur ein weiterer Try
            try
            {
                Ping myPing = new Ping();
                for (int i = 0; i < 10; i++)
                {
                    PingReply reply = myPing.Send(ipAddressOfVse, portOfVse);
                    if (reply != null)
                    {
                        Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString());

                    }
                }
            }
            catch
            {
                Console.WriteLine("ERROR: You have Some TIMEOUT issue");
            }
        }
    }
}
