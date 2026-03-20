namespace Mplace2.Gui;

public partial class MyClass {


    Dictionary<string, int>? Limits { get; set; }

    /// <summary>Limit on request size in bytes.</summary>
    public int RequestSize { get; set; }

    /// <summary>Limit on number of posts per hour.</summary>
    public int PostsPerHour { get; set; }

    /// <summary>Limit on post size in bytes.</summary>
    public int PostSize { get; set; }

    /// <summary>Limit on comment size in characters.</summary>
    public int CommentSize { get; set; }

    /// <summary>Limit on user storage in bytes.</summary>
    public int UserStorage { get; set; }


    public void SetLimits(Dictionary<string, int>? limits) {
        Limits = limits;
        RequestSize = SetLimit("RequestSize");
        PostsPerHour = SetLimit("PostsPerHour");
        PostSize = SetLimit("PostSize");
        CommentSize = SetLimit("CommentSize");
        UserStorage = SetLimit("UserStorage");
        }

    int SetLimit(string key) =>
        Limits.TryGetValue(key, out var result) ? result : -1;




    }
