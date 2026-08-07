
using System.Net;

using DocumentFormat.OpenXml.InkML;

using Goedel.Cryptography.Oauth;
using Goedel.Discovery;
using Goedel.Mesh;

namespace Mplace2.Gui;


public partial class SignOut {
    public override async Task<CallbackResult> Callback(
                IPageContext context) {
        var path = context as ParsedPath;
        var persistPlace = path.PersistPlace;

        var cookie = persistPlace.SignOut();

        return new(HttpStatusCode.OK, null, "/", [cookie]);
        }
    }



public partial class HandleInput {




    public override async Task<CallbackResult> Callback(
                IPageContext context) {
        var path = context as ParsedPath;
        var persistPlace = path.PersistPlace;

        List<FormReaction> reactions = [];


        if (DNS is null || DNS?.Length == 0) {
            reactions.Add(new("DNS", "Must not be null"));
            return new(HttpStatusCode.BadRequest, reactions, null);
            }

        else if (!DNS.TryParseServiceAddress(out var address)) {
            reactions.Add(new("DNS", "Must be a valid DNS address or handle"));

            }
        else if (address.AddressType != ParsedAddressType.Dns & address.AddressType != ParsedAddressType.Callsign) {
            reactions.Add(new("DNS", "Must be a valid DNS address or handle"));
            }


        if (reactions.Count > 0) {
            return new(HttpStatusCode.BadRequest, reactions, null);
            }


        // We will at some point want to be able to throw a 'must sign in' page at the user
        // and return them to the place they were prompted for input.



        var nonceDns = new NonceDns(Udf.Nonce(), path.Uri.DnsSafeHost, DNS);
        var redirect = nonceDns.Uri(path.Uri.DnsSafeHost, "/");


        Console.WriteLine($"%%%%    {redirect}");

        // Perform OAUTH Push
        var preRequest = await persistPlace.OauthClient.PreRequest(DNS, redirect);

        if (preRequest is OauthClientResultFail fail) {
            // throw error here
            throw new NYI();
            }
        var success = preRequest as OauthClientResultPreRequest;



        return new(HttpStatusCode.OK, null, success.RedirectUri);
        }


    }
