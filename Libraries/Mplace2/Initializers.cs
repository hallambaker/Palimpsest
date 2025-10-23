using Goedel.Discovery;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mplace2.Gui;






public partial class User {


    // This is how we will be overriding the avatar when we get to it...
    /// <inheritdoc/>
    public override string? GetAvatar => DefaultAvatar;

    //public override string? GetAvatar => $"/Avatar/{DID}";


    }