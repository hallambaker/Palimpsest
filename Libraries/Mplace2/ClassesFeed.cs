using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.Mesh.Client;

namespace Mplace2.Gui;


public partial class PostsPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var pageContext = context as ParsedPath;
        pageContext.CheckAuthorization(Privilege.ReadFeed);


        var persist = pageContext.PersistPlace as PersistPlace;
        var place = pageContext.PlaceId;

        // if no feed is specified, use the first ID.
        var feed = pageContext.FeedId;

        using var postsHandle = persist.CatalogCache.GetFeedPosts(place, feed) ;
        var posts = postsHandle.Value;

        if (posts == null) {
            throw new NYI(); // here return the feed not found thing.
            }

        var entries = new List<Entry>();
        foreach (var postIndex in posts.EntriesReverse()) {
            var post = posts.GetValue(postIndex);
            entries.Add(new Post(pageContext, place, feed, post));
            }

        var page = new PostsPage() {
            FrameSet = FrameSet,
            Entries = entries
            };

        return page;

        }

    }

