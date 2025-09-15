using Goedel.Cryptography;
using Goedel.IO;
using Goedel.Protocol;

using Microsoft.Extensions.Options;

namespace Frame;



class MainClass {
    static void Main(string[] args) {


        // Options
        var GenderOptions = MakeOptions("Masculine", "Feminine", "Common", "Animate", "Inanimate", "Neuter");

        var RelationOptions = MakeOptions("Emergency");
        AddOptionsNoIcons (RelationOptions,"Parent","Sibling","Spouse","Child","Kin","Agent",
                "Colleague","Co-resident","Ccquaintance","Co-worker","Contact","Crush",
                "Date","Friend","Me","Met","Muse","Neighbor","Sweetheart");

        var MessengerOptions = new List<ServiceOption> {
            new () {
                Text="@ny",
                Icon ="Brands/Any"
                },
            new () {
                Text="Signal",
                Icon ="Brands/Signal"
                },
            new () {
                Text="Facebook Messenger",
                Icon ="Brands/FacebookMessenger"
                },
            new () {
                Text="Instagram",
                Icon ="Brands/Instagram"
                },
            new () {
                Text="Snapchat",
                Icon ="Brands/SnapChat"
                },
            new () {
                Text="Telegram",
                Icon ="Brands/Telegram"
                },
            new () {
                Text="WhatsApp",
                Icon ="Brands/WhatsApp"
                }
            };

        // iMessage, Kik, RakutenViber, WeChat, DingTalk, Feishu

        FixIds(MessengerOptions);


        var ServiceOptions = new List<ServiceOption> {
            new () {
                Text="BlueSky",
                Icon ="Brands/BlueSky",
                Template ="https://bsky.app/profile/%user"
                },
            new () {
                Text="Mastodon",
                Icon ="Brands/Mastodon"
                },
            new () {
                Text="Twitter",
                Icon ="Brands/Twitter",
                Template ="https://x.com/%user"
                },
            new () {
                Text="LinkedIn",
                Icon ="Brands/LinkedIn",
                Template ="https://www.linkedin.com/in/%user/"
                },
            new () {
                Text="Facebook",
                Icon ="Brands/Facebook",
                Template ="https://www.facebook.com/%user"
                },
            new () {
                Text="WordPress",
                Icon ="Brands/WordPress",
                Template =""
                },
            new () {
                Text="Medium",
                Icon ="Brands/Medium",
                Template ="https://medium.com/@%user"
                },
            new () {
                Text="GitHub",
                Icon ="Brand/Github",
                Template ="https://github.com/%user"
                }, 
            new () {
                Text="YouTube",
                Icon ="Brands/YouTube",
                Template ="https://www.youtube.com/channel/@id"
                },
            new () {
                Text="Reddit",
                Icon ="Brands/Reddit",
                Template ="https://www.reddit.com/r/%user/"
                },
            new () {
                Text="Twitch",
                Icon ="Brands/Twitch",
                Template ="https://www.twitch.tv/%user"
                },
            new () {
                Text="Tumblr",
                Icon ="Brands/Tumblr",
                Template ="https://www.tumblr.com/%user"
                },
            new () {
                Text="Threads",
                Icon ="Brands/Threads",
                Template ="https://www.threads.com/@%user"
                },
            new () {
                Text="TikTok",
                Icon ="Brands/TikTok",
                Template ="https://www.tiktok.com/@%user"
                }
            };

        var ModalityOptions = MakeOptions("Voice", "Mobile", "Home", "Office", "Message", "Mail", "Video", "File",
                    "Web", "Blog", "Podcast", "Multimedia");
        AddOptionsNoIcons(ModalityOptions, "Textphone", "Fax", "Pager");
        SetIcon(ModalityOptions, "File", "FolderTree");


        var ApplicationOptions = new List<ServiceOption> {
            new () {
                Text="Git",
                Icon ="Brands/Git"
                },
            new () {
                Text="SSH",
                Icon ="Brands/SSH"
                },
            new () {
                Text="Code Signing",
                Icon ="Sign"
                },
            new () {
                Text="S/MIME",
                Icon ="Brands/SMIME"
                },
            new () {
                Text="PKIX Root",
                Icon ="Brands/CertificateRoot"
                },
            new () {
                Text="PKIX Intermediate",
                Icon ="Brands/CertificateIntermediate"
                }
            ,
            new () {
                Text="PKIX End Entity",
                Icon ="Brands/CertificateEndEntity"
                },
            new () {
                Text="OpenPGP",
                Icon ="Brands/OpenPGP"
                }
            };


        var MediaOptions = MakeOptions("Avatar", "Photo", "Logo", "Banner");

        //var frameset = new MyClass();

        //var user1 = new User() {
        //    DID = Udf.Nonce(),
        //    DisplayName = "Alice",
        //    DisplayHandle = "@alice.example.com"
        //    };

        //var user2 = new User() {
        //    DID = Udf.Nonce(),
        //    DisplayName = "Bob",
        //    DisplayHandle = "@bob.example.com"
        //    };

        //var user3 = new User() {
        //    DID = Udf.Nonce(),
        //    DisplayName = "Carol",
        //    DisplayHandle = "@carol.example.com"
        //    };

        //var user4 = new User() {
        //    DID = Udf.Nonce(),
        //    DisplayName = "Mallet",
        //    DisplayHandle = "@mallet.example.com"
        //    };


        //var post1 = new Post() {
        //    Uid = Udf.Nonce(),
        //    User = user1,
        //    Text = "This is a post that was made. It is very gud.",
        //    Created = System.DateTime.Now - TimeSpan.FromDays(1),
        //    Liked = true,
        //    Likes = 42
        //    };

        //// missing the quoted post
        //var post2 = new Post() {
        //    Uid = Udf.Nonce(),
        //    User = user2,
        //    Text = "Not sure this post as 'gud' as the poster thought.",
        //    Created = System.DateTime.Now - TimeSpan.FromHours(3),
        //    QuotedPost = post1
        //    };

        //// missing the quoted post
        //var post3 = new Repost() {
        //    Uid = Udf.Nonce(),
        //    QuotedPost = post1,
        //    Created = System.DateTime.Now - TimeSpan.FromMinutes(3),
        //    Reposter = user3
        //    };

        //var post4 = new Repost() {
        //    Uid = Udf.Nonce(),
        //    QuotedPost = post2,
        //    Created = System.DateTime.Now - TimeSpan.FromMinutes(7),
        //    Reposter = user4
        //    };


        //frameset.Resources = [
        //    new Stylesheet("Resources/stylesheet.css", "text/css") 
        //    ];


        //frameset.ProfileSelect.DisplayName = "";
        //frameset.HomePage.Items = [post1, post2, post3, post4];

        ////var writer = new PageWriter(frameset, Console.Out);
        ////writer.Render(frameset.HomePage);



        //using (var file = "Test/HomePage.html".OpenTextWriterNew()) {
        //    var writer = new PageWriter(frameset, file);
        //    writer.Render(frameset.HomePage);
        //    }



        // Produce a set of contact sheets for each page

        }
    public static List<Option> MakeOptions(params string[] identifiers) => MakeOptions<Option>(identifiers);

    public static List<T> MakeOptions<T>(params string[] identifiers) where T : Option, new() {
        var result = new List<T>();

        foreach (string identifier in identifiers) {
            var option = new T() {
                Id = identifier.ToLower(),
                Text =identifier,
                Icon = identifier
                };
            result.Add(option);
            }

        return result;
        }

    public static void AddOptionsNoIcons<T>(
                List<T> options, params string[] identifiers) where T : Option, new() {

        foreach (string identifier in identifiers) {
            var option = new T() {
                Id = identifier.ToLower(),
                Text = identifier,
                Icon = identifier
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

    public Option() : this(null) {
        }

    }