namespace Goedel.Html;

public interface IFrameField {
    string Backing { get; }

    string Id { get; }
    string Tag { get; init; }
    string Type { get; }

    string Prompt { get; set; }

    bool Hidden { get; set; }

    string Description { get; set; }


    }