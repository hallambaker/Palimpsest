using DocumentFormat.OpenXml.Spreadsheet;

using Goedel.Mesh.Client;

namespace Mplace2.Gui;


public partial class PostsPage {

    public override Goedel.Sitebuilder.FramePage GetPage(IPersistSite persistPlace, IPageContext context) {

        var path = context as ParsedPath;
        path.CheckAuthorization(Privilege.ReadFeed);


        var persist = path.PersistPlace as PersistPlace;
        var place = path.PlaceId;

        // if no feed is specified, use the first ID.
        var feed = path.FeedId;

        using var postsHandle = persist.CatalogCache.GetFeedPosts(place, feed) ;
        var posts = postsHandle.Value;

        if (posts == null) {
            throw new NYI(); // here return the feed not found thing.
            }

        var entries = new List<Entry>();
        foreach (var postIndex in posts.EntriesReverse()) {
            var post = posts.GetValue(postIndex);
            entries.Add(new Post(persist, place, feed, post));
            }

        var page = new PostsPage() {
            FrameSet = FrameSet,
            Entries = entries
            };

        return page;

        }

    }

