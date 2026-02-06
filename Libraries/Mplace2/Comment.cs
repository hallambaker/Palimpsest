using DocumentFormat.OpenXml.Wordprocessing;

namespace Mplace2.Gui;
public partial class Comment {

    public ButtonVisibility? Liked { get; set; }

    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }





    public override Task<CallbackResult> Callback(IPageContext context) {
        var place = GetPlace(context);
        var persist = context.GetPersist();
        var path = context as ParsedPath;

        //var catalogedPost = new Cat
        var catalogedPost = new CatalogedComment() {
            Author = path.MemberHandle?.PrimaryKey,
            Text = Text,
            };
        persist.Add(place.Uid, path.FirstId, path.SecondId, catalogedPost);


        return base.Callback(context);
        }


    }