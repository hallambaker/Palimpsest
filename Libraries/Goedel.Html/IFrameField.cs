namespace Goedel.Html;

public interface IFrameField {
    string Backing { get; }
    string Tag { get; init; }
    string Type { get; }

    }