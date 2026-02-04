namespace Mplace2.Gui;

public partial class Post {

    public ButtonVisibility? Liked { get; set; }

    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }


    public override Task<CallbackResult> Callback(IPageContext context) {
        var place = GetPlace(context);

        // get the catalog for the stream


        // add the post to the catalog

        //var catalogedPost = new Cat





        return base.Callback(context);
        }


    }
