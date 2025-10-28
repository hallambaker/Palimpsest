
using Goedel.Discovery;

using System.Net;

namespace Mplace2.Gui;

public partial class HandleInput {

    public override HttpStatusCode Validate(
                IPersistPlace persistPlace,
                out List<FormReaction>? reactions) {
        reactions = [];

        if (DNS is null || DNS?.Length == 0) {
            reactions.Add(new("DNS", "Must not be null"));
            return HttpStatusCode.BadRequest;
            }

        if (!DNS.TryParseServiceAddress(out var address)) {
            reactions.Add(new("DNS", "Must be a valid DNS address or handle"));
            return HttpStatusCode.BadRequest;
            }
        if (address.AddressType != ParsedAddressType.Dns & address.AddressType != ParsedAddressType.Callsign) {
            reactions.Add(new("DNS", "Must be a valid DNS address or handle"));
            return HttpStatusCode.BadRequest;
            }


        return HttpStatusCode.OK;
        }
    public override HttpStatusCode Commit(
                IPersistPlace persistPlace,
                out string? redirect) {
        redirect = null;
        return HttpStatusCode.OK;
        }

    }
