using Goedel.Discovery;

using System.Net;

namespace Scratchpad;

internal class Program {
    static void Main(string[] args) {

        //var client = DnsClient.Default;
        //var context = client.GetContext();

        //var listen = ListenUdp(context);
        //var request = new DNSRequest("example.com", DNSTypeCode.TXT);
        //context.SendRequest (request);
        //context.SendRequest(request);
        //context.SendRequest(request);

        //context.SendRequest(request);
        //context.SendRequest(request);
        //context.SendRequest(request);


        //listen.Sync();


        //var udpClient = 
        TestOauth.Test().TestDidResolve();
        }



    public static async Task ListenUdp(DNSContext context) {

        while (true) {

            var result = await context.GetResponseRawAsync();
            Console.WriteLine("Ping!");




            }




        }



    }
