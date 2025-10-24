using Goedel.Cryptography;
using Goedel.IO;
using Goedel.Protocol;

using Microsoft.Extensions.Options;

namespace Mplace2.Gui;



class MainClass {
    //static void Main(string[] args) {


    //    // Options
    //    var GenderOptions = MakeOptions("Masculine", "Feminine", "Common", "Animate", "Inanimate", "Neuter");

    //    var RelationOptions = MakeOptions("Emergency");
    //    AddOptionsNoIcons (RelationOptions,"Parent","Sibling","Spouse","Child","Kin","Agent",
    //            "Colleague","Co-resident","Ccquaintance","Co-worker","Contact","Crush",
    //            "Date","Friend","Me","Met","Muse","Neighbor","Sweetheart");

    //    var MessengerOptions = new List<ServiceOption> {
    //        new () {
    //            Text="@ny",
    //            Icon ="Brands/Any"
    //            },
    //        new () {
    //            Text="Signal",
    //            Icon ="Brands/Signal"
    //            },
    //        new () {
    //            Text="Facebook Messenger",
    //            Icon ="Brands/FacebookMessenger"
    //            },
    //        new () {
    //            Text="Instagram",
    //            Icon ="Brands/Instagram"
    //            },
    //        new () {
    //            Text="Snapchat",
    //            Icon ="Brands/SnapChat"
    //            },
    //        new () {
    //            Text="Telegram",
    //            Icon ="Brands/Telegram"
    //            },
    //        new () {
    //            Text="WhatsApp",
    //            Icon ="Brands/WhatsApp"
    //            }
    //        };

    //    // iMessage, Kik, RakutenViber, WeChat, DingTalk, Feishu

    //    FixIds(MessengerOptions);


    //    var ServiceOptions = new List<ServiceOption> {
    //        new () {
    //            Text="BlueSky",
    //            Icon ="Brands/BlueSky",
    //            Template ="https://bsky.app/profile/%user"
    //            },
    //        new () {
    //            Text="Mastodon",
    //            Icon ="Brands/Mastodon"
    //            },
    //        new () {
    //            Text="Twitter",
    //            Icon ="Brands/Twitter",
    //            Template ="https://x.com/%user"
    //            },
    //        new () {
    //            Text="LinkedIn",
    //            Icon ="Brands/LinkedIn",
    //            Template ="https://www.linkedin.com/in/%user/"
    //            },
    //        new () {
    //            Text="Facebook",
    //            Icon ="Brands/Facebook",
    //            Template ="https://www.facebook.com/%user"
    //            },
    //        new () {
    //            Text="WordPress",
    //            Icon ="Brands/WordPress",
    //            Template =""
    //            },
    //        new () {
    //            Text="Medium",
    //            Icon ="Brands/Medium",
    //            Template ="https://medium.com/@%user"
    //            },
    //        new () {
    //            Text="GitHub",
    //            Icon ="Brand/Github",
    //            Template ="https://github.com/%user"
    //            }, 
    //        new () {
    //            Text="YouTube",
    //            Icon ="Brands/YouTube",
    //            Template ="https://www.youtube.com/channel/@id"
    //            },
    //        new () {
    //            Text="Reddit",
    //            Icon ="Brands/Reddit",
    //            Template ="https://www.reddit.com/r/%user/"
    //            },
    //        new () {
    //            Text="Twitch",
    //            Icon ="Brands/Twitch",
    //            Template ="https://www.twitch.tv/%user"
    //            },
    //        new () {
    //            Text="Tumblr",
    //            Icon ="Brands/Tumblr",
    //            Template ="https://www.tumblr.com/%user"
    //            },
    //        new () {
    //            Text="Threads",
    //            Icon ="Brands/Threads",
    //            Template ="https://www.threads.com/@%user"
    //            },
    //        new () {
    //            Text="TikTok",
    //            Icon ="Brands/TikTok",
    //            Template ="https://www.tiktok.com/@%user"
    //            }
    //        };

    //    var ModalityOptions = MakeOptions("Voice", "Mobile", "Home", "Office", "Message", "Mail", "Video", "File",
    //                "Web", "Blog", "Podcast", "Multimedia");
    //    AddOptions(ModalityOptions, 2, "Textphone", "Fax", "Pager");
    //    SetIcon(ModalityOptions, "File", "FolderTree");


    //    var ApplicationOptions = new List<ServiceOption> {
    //        new () {
    //            Text="Git",
    //            Icon ="Brands/Git"
    //            },
    //        new () {
    //            Text="SSH",
    //            Icon ="Brands/SSH"
    //            },
    //        new () {
    //            Text="Code Signing",
    //            Icon ="Sign"
    //            },
    //        new () {
    //            Text="S/MIME",
    //            Icon ="Brands/SMIME"
    //            },
    //        new () {
    //            Text="PKIX Root",
    //            Icon ="Brands/CertificateRoot"
    //            },
    //        new () {
    //            Text="PKIX Intermediate",
    //            Icon ="Brands/CertificateIntermediate"
    //            },
    //        new () {
    //            Text="PKIX End Entity",
    //            Icon ="Brands/CertificateEndEntity"
    //            },
    //        new () {
    //            Text="OpenPGP",
    //            Icon ="Brands/OpenPGP"
    //            }
    //        };


    //    var MediaOptions = MakeOptions("Avatar", "Photo", "Logo", "Banner");

    //    var frameset = new MyClass();
    //    frameset.Resources = [
    //        new Stylesheet("Resources/stylesheet.css", "text/css"),
    //        new Stylesheet("Resources/quill.css", "text/css"),
    //        new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")
    //        ];
    //    frameset.EndResources = [
    //        new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
    //        new Script("Resources/quill.js","text/javascript")
    //];


    //    var basePlace = new Place() {
    //        Uid = Udf.Nonce(),
    //        DNS ="mplace2.social",
    //        Title="MPlace2",
    //        Description = "Making personal places on the Web",
    //        Banner = "Mplace2Banner.png",
    //        Avatar = "avatar.png"
    //        };

    //    var phbPlace = new Place() {
    //        Uid = Udf.Nonce(),
    //        DNS = "phill.hallambaker.com",
    //        Title = "Phill's Place",
    //        Description = "PHB's place on the Web",
    //        Banner = "PHBBanner.png",
    //        Avatar = "PHBInDalek.png"
    //        };

    //    var buildingPlace = new Place() {
    //        Uid = Udf.Nonce(),
    //        DNS = "building.mplace2.social",
    //        Title = "MPlace2 Building",
    //        Description = "Building MPlace2",
    //        Banner = "Mplace2Banner.png",
    //        Avatar = "avatar.png"
    //        };

    //    var anyonePlace = new Place() {
    //        Uid = Udf.Nonce(),
    //        DNS = "anyone.mplace2.social",
    //        Title = "MPlace2",
    //        Description = "Intelligent contacts that work",
    //        Banner = "Mplace2Banner.png",
    //        Avatar = "avatar.png"
    //        };

    //    var anythingPlace = new Place() {
    //        Uid = Udf.Nonce(),
    //        DNS = "anything.mplace2.social",
    //        Title = "@nything",
    //        Description = "Making personal devices personal.",
    //        Banner = "Mplace2Banner.png",
    //        Avatar = "avatar.png"
    //        };

    //    //frameset.ProfileSelect.DisplayName = "";
    //    frameset.HomePage.Entries = [phbPlace, buildingPlace, anyonePlace, anythingPlace];
    //    frameset.HomePage.MainEntry = basePlace;



    //    var user1 = new User() {
    //        Uid = Udf.Nonce(),
    //        DisplayName = "Alice",
    //        DisplayHandle = "alice.example.com"
    //        };

    //    var user2 = new User() {
    //        Uid = Udf.Nonce(),
    //        DisplayName = "Bob",
    //        DisplayHandle = "bob.example.com"
    //        };

    //    var user3 = new User() {
    //        Uid = Udf.Nonce(),
    //        DisplayName = "Carol",
    //        DisplayHandle = "carol.example.com"
    //        };


    //    var post1 = new Post() {
    //        Uid = Udf.Nonce(),
    //        User = user1,
    //        Title = "First Post!",
    //        Summary = "I am the first person to post here! Sweeeet!",
    //        Body = "<h1>Not really got anything to say mind</h1>" +
    //        "<p>In fact this post is a bit boring to be honest.</p>" +
    //        "<p>Maybe the next one will be better."
    //        };


    //    var post2 = new Post() {
    //        Uid = Udf.Nonce(),
    //        User = user1,
    //        Title = "Try again",
    //        Summary = "Trying a second post here",
    //        Body = "<p>So much for having something to say!</p>"
    //        };

    //    var post3 = new Post() {
    //        Uid = Udf.Nonce(),
    //        User = user2,
    //        Title = "Oh, just thought of something",
    //        Summary = "This is the text that goes out to Blue Sky, Facebook, etc.",
    //        Body = "<h1>This text doesn't get posted anywhere else, just here.</h1>" +
    //        "<p>Unless of course, there is some reason to do it different</p>" +
    //        "<p>A user could use a service that allows them to make a post, share" +
    //        "it with a small audience initially and then post the whole thing" +
    //        "to Facebook/OnlyFans/Subspace/etc. after discussions.</p>"
    //        };



    //    var post4 = new Post() {
    //        Uid = Udf.Nonce(),
    //        User = user3,
    //        Title = "What about user links",
    //        Summary = "Need to work out how the user link thing works.",
    //        Body = "<h1>Need to do some reasearch here</h1>"
    //        };


    //    var comment1 = new Comment() {
    //        Uid = Udf.Nonce(),
    //        User = user3,
    //        Text = "A good start to commenting",
    //        Created = System.DateTime.UtcNow
    //        };

    //    var comment2 = new Comment() {
    //        Uid = Udf.Nonce(),
    //        User = user1,
    //        Text = "I will just comment as well",
    //        Created = System.DateTime.UtcNow
    //        };

    //    var comment3 = new Comment() {
    //        Uid = Udf.Nonce(),
    //        User = user2,
    //        Text = "Good point!",
    //        Created = System.DateTime.UtcNow
    //        };




    //    var dummyText = "<h1>This is a dummy page</h1>" +
    //        "<p>will be filled as needed</p>" +
    //        "<p>will be filled as needed</p>" +
    //        "<p>will be filled as needed</p>" +
    //        "<p>will be filled as needed</p>" +
    //        "<p>will be filled as needed</p>";

    //    frameset.Help.Text = dummyText;
    //    frameset.TermsOfService.Text = dummyText;
    //    frameset.PrivacyPolicy.Text = dummyText;
    //    frameset.Contributors.Text = dummyText;
    //    frameset.Status.Text = dummyText;
    //    frameset.SystemLog.Text = dummyText;
    //    frameset.Repository.Text = dummyText;

    //    //frameset.SignIn.Title = "Sign In";
    //    frameset.SignIn.Text = "Enter your Blue Sky handle here";
    //    frameset.SignIn.RegisterText = "If you don't have a handle yet, you can register one here";

    //    frameset.YourPlacePage.MainEntry = phbPlace;
    //    frameset.YourPlacePage.Entries = [post1, post2, post3, post4];
    //    frameset.MainNav.SignInState = SignInState.HasPersonalPlace;

    //    frameset.PostPage.MainEntry = post1;
    //    frameset.PostPage.Entries = [comment1, comment2, comment3];

    //    // Write out contact sheets for each page
    //    foreach (var page in frameset.Pages) {
    //        var fileName = $"Test/{page.Id}.html";
    //        using var file = fileName.OpenTextWriterNew();
    //        frameset.Page = page;

    //        var writer = new PageWriter(frameset, file);
    //        writer.Render(page);
    //        }




    //    }
   
    
    public static List<Option> MakeOptions(params string[] identifiers) => MakeOptions<Option>(identifiers);

    public static List<T> MakeOptions<T>(params string[] identifiers) where T : Option, new() {
        var result = new List<T>();

        foreach (string identifier in identifiers) {
            var option = new T() {
                Id = identifier.ToLower(),
                Text =identifier,
                Icon = identifier,
                Priority = 0
                };
            result.Add(option);
            }

        return result;
        }

    public static void AddOptions<T>(
            List<T> options, int priority, params string[] identifiers) where T : Option, new() {

        foreach (string identifier in identifiers) {
            var option = new T() {
                Id = identifier.ToLower(),
                Text = identifier,
                Icon = identifier,
                Priority = priority
                };
            options.Add(option);
            }

        }

    public static void AddOptionsNoIcons<T>(
                List<T> options, params string[] identifiers) where T : Option, new() {

        foreach (string identifier in identifiers) {
            var option = new T() {
                Id = identifier.ToLower(),
                Text = identifier
                };
            options.Add(option);
            }

        }

    public static void SetIcon<T>(List<T> options, string id, string icon) where T : Option {

        foreach (var option in options) {
            if (option.Id == id.ToLower()) {
                option.Icon = icon;
                return;
                }
            }
        }

    public static List<T> FixIds<T>(List<T> options) where T : Option {

        foreach (var option in options) {
            option.Id = option.Text.ToLower();
            option.Icon ??= option.Text;
            }

        return options;
        }

    }
public partial class Option {



    }
