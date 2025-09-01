using Goedel.Cryptography;
using Goedel.IO;

namespace Frame;



class MainClass {
    static void Main(string[] args) {



        var frameset = new MyClass();

        var user1 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Alice",
            DiaplayHandle = "alice.example.com"
            };

        var user2 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Bob",
            DiaplayHandle = "alice.example.com"
            };

        var user3 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Carol",
            DiaplayHandle = "alice.example.com"
            };

        var user4 = new User() {
            DID = Udf.Nonce(),
            DisplayName = "Mallet",
            DiaplayHandle = "alice.example.com"
            };

        var post1 = new NewPost() {
            Id = Udf.Nonce(),
            User = user1,
            Text = "This is a post that was made. It is very gud.",
            Created = System.DateTime.Now
            };

        // missing the quoted post
        var post2 = new QuotePost() {
            Id = Udf.Nonce(),
            User = user2,
            Text = "Not sure this post as 'gud' as the poster thought.",
            Created = System.DateTime.Now
            };

        // missing the quoted post
        var post3 = new RePost() {
            Id = Udf.Nonce(),
            User = user3,
            Created = System.DateTime.Now
            };

        frameset.ProfileSelect.DisplayName = "";

        frameset.HomePage.Items = [post1, post2, post3];

        var writer = new PageWriter(frameset, Console.Out);
        writer.Render(frameset.HomePage);

        }
    }
