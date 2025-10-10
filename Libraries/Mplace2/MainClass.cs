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
        AddOptions(ModalityOptions, 2, "Textphone", "Fax", "Pager");
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
                },
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

        var frameset = new MyClass();
        frameset.Resources = [
            new Stylesheet("Resources/stylesheet.css", "text/css"),
            new Stylesheet("Resources/quill.css", "text/css"),
            new Stylesheet("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.snow.css", "text/css")
            ];
        frameset.EndResources = [
            new Script("https://cdn.jsdelivr.net/npm/quill@2.0.3/dist/quill.js","text/javascript"),
            new Script("Resources/quill.js","text/javascript")
    ];


        var basePlace = new Place() {
            DNS="mplace2.social",
            Title="MPlace2",
            Description = "Making personal places on the Web",
            Banner = "Mplace2Banner.png",
            Avatar = "avatar.png"
            };

        var phbPlace = new Place() {
            DNS = "phill.hallambaker.com",
            Title = "Phill's Place",
            Description = "PHB's place on the Web",
            Banner = "PHBBanner.png",
            Avatar = "PHBInDalek.png"
            };

        var buildingPlace = new Place() {
            DNS = "building.mplace2.social",
            Title = "MPlace2 Building",
            Description = "Building MPlace2",
            Banner = "Mplace2Banner.png",
            Avatar = "avatar.png"
            };

        var anyonePlace = new Place() {
            DNS = "anyone.mplace2.social",
            Title = "MPlace2",
            Description = "Intelligent contacts that work",
            Banner = "Mplace2Banner.png",
            Avatar = "avatar.png"
            };

        var anythingPlace = new Place() {
            DNS = "anything.mplace2.social",
            Title = "@nything",
            Description = "Making personal devices personal.",
            Banner = "Mplace2Banner.png",
            Avatar = "avatar.png"
            };

        //frameset.ProfileSelect.DisplayName = "";
        frameset.HomePage.Places = [phbPlace, buildingPlace, anyonePlace, anythingPlace];
        frameset.HomePage.MetaPlace = basePlace;


        using (var file = "Test/SignIn.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.SignIn);
            }



        using (var file = "Test/Places.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.HomePage);
            }



        using (var file = "Test/SwitchPage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.SwitchPage);
            }

        using (var file = "Test/NotificationsPage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.NotificationsPage);
            }

        using (var file = "Test/BookmarkPage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.BookmarkPage);
            }

        using (var file = "Test/YourPlacePageCreate.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.YourPlacePageCreate);
            }

        using (var file = "Test/YourPlacePage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.YourPlacePage);
            }
        using (var file = "Test/SettingsPage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.SettingsPage);
            }
        using (var file = "Test/NewPlacePage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.NewPlacePage);
            }
        using (var file = "Test/AboutSettingsPage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.AboutSettingsPage);
            }



        using (var file = "Test/CreatePost.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.CreatePost);
            }


        using (var file = "Test/CreateComment.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.CreateComment);
            }
        // Produce a set of contact sheets for each page

        }
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

    public Option() : this(null) {
        }

    }