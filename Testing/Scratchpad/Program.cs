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
        //OauthClient.GenKey();
        //var key = KeyPair.Factory(CryptoAlgorithmId.P256, KeySecurity.Ephemeral);


        //TestOauth.Test().TestDidResolve();
        //TestOauth.Test().TestEncDed();

        TestOauth.Test().TestJsContact();
        Console.WriteLine("");


        }



    public static async Task ListenUdp(DNSContext context) {

        while (true) {

            var result = await context.GetResponseRawAsync();
            Console.WriteLine("Ping!");
            }
        }

    }
