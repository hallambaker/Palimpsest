namespace Mplace2.Gui;

public partial class Post {

    public ButtonVisibility? Liked { get; set; }

    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }


    public override Task<CallbackResult> Callback(IPageContext context) {
        var place = GetPlace(context);
        var persist = context.GetPersist();
        var path = context as ParsedPath;

        //var catalogedPost = new Cat
        var catalogedPost = new CatalogedPost() {
            Title = Title,
            Author = path.MemberHandle?.PrimaryKey,
            Summary = Summary,
            Body = Body
            };
        persist.Add(place.Uid, path.FirstId, catalogedPost);


        return base.Callback(context);
        }





    }
