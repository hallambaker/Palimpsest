using Goedel.Cryptography;
using Goedel.IO;

namespace Frame;



class MainClass {
    static void Main(string[] args) {



        var frameset = new MyClass();

        var user1 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Alice",
            DisplayHandle = "alice.example.com"
            };

        var user2 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Bob",
            DisplayHandle = "bob.example.com"
            };

        var user3 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Carol",
            DisplayHandle = "carol.example.com"
            };

        var user4 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Mallet",
            DisplayHandle = "mallet.example.com"
            };

        
        var post1 = new Post() {
            Uid = Udf.Nonce(),
            User = user1,
            Text = "This is a post that was made. It is very gud.",
            Created = System.DateTime.Now - TimeSpan.FromDays(1),
            };

        // missing the quoted post
        var post2 = new QuotePost() {
            Uid = Udf.Nonce(),
            User = user2,
            Text = "Not sure this post as 'gud' as the poster thought.",
            Created = System.DateTime.Now - TimeSpan.FromHours(3)
            };

        // missing the quoted post
        var post3 = new RePost() {
            Uid = Udf.Nonce(),
            User = user3,
            Created = System.DateTime.Now - TimeSpan.FromMinutes(3)
            };

        frameset.Resources = [
            new Stylesheet("Resources/stylesheet.css", "text/css") 
            ];


        frameset.ProfileSelect.DisplayName = "";
        frameset.HomePage.Items = [post1, post2, post3];

        //var writer = new PageWriter(frameset, Console.Out);
        //writer.Render(frameset.HomePage);



        using (var file = "Test/HomePage.html".OpenTextWriterNew()) {
            var writer = new PageWriter(frameset, file);
            writer.Render(frameset.HomePage);
            }



        // Produce a set of contact sheets for each page

        }
    }
