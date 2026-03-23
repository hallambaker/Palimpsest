using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.Extensions.Hosting;

namespace Mplace2.Gui;

public partial class Post {

    public ButtonVisibility? Liked { get; set; }
    public ButtonVisibility? RequestedMore { get; set; }
    public ButtonVisibility? RequestedLess { get; set; }

    public string PostLink { get; set; }
    public string AuthorLink { get; set; }
    public string PostPath { get; set; }

    //public string AuthorAvatar { get; set; }




    public Post(
                    PersistPlace persist, 
                    string placeId, 
                    string feedId, 
                    CatalogedPost catalogedPost) : this(catalogedPost.Uid) {
        Body = catalogedPost.Body;
        Summary = catalogedPost.Summary;
        Title = catalogedPost.Title;
        User = persist.GetUser(catalogedPost.Author);
        //User = post.Author;

        SetLinks(persist, placeId, feedId, catalogedPost);
        }


    public override Task<CallbackResult> Callback(IPageContext context) {
        var pageContext = context as ParsedPath;
        var persist = pageContext.PersistPlace as PersistPlace;

        pageContext.CheckAuthorization(Privilege.CreatePost, FeedId).AssertTrue(NYI.Throw);


        if (Body != null) {
            var valid = RichtextValidator.Validate(Body);
            if (valid != RichetextResult.Valid) {
                Body = null;
                }
            }


        var catalogedPost = new CatalogedPost() {
            Uid = persist.CreatePostId(),
            Title = Title,
            Author = pageContext.AuthorId,
            Summary = Summary,
            Body = Body
            };

        persist.Add(pageContext.PlaceId, FeedId, catalogedPost);
        SetLinks(persist, pageContext.PlaceId, FeedId, catalogedPost);



        var returnPage = persist.GetFeedLink(pageContext);
        return Task.FromResult(CallbackResult.CreatedRedirect(returnPage));

        }



    private void SetLinks(PersistPlace persist, string placeId, string feedId, CatalogedPost post) {
        PostLink = persist.GetPostLink(feedId, post._PrimaryKey);
        PostPath = persist.GetPostPath(feedId, post._PrimaryKey);
        AuthorLink = persist.GetAuthorLink(post.Author);
        //AuthorAvatar = persist.GetMemberAvatar(post.Author);
        }

    }
