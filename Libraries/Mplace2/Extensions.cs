namespace Mplace2.Gui;

public static class Extensions {

    /// <summary>If the privilege <paramref name="granted"/> has the bits specified by
    /// <paramref name="require"/> set, return <see cref="ButtonVisibility.Available"/>,
    /// otherwise <see cref="ButtonVisibility.Disabled"/>,
    /// otherwise return </summary>
    /// <param name="granted"></param>
    /// <param name="require"></param>
    /// <returns></returns>

    static public ButtonVisibility ButtonAvailableDisabled(
            this Privilege granted, Privilege require) =>
         ((granted & require) == require) ? ButtonVisibility.Available : ButtonVisibility.Disabled;

    /// <summary>If the privilege <paramref name="granted"/> has the bits specified by
    /// <paramref name="require"/> set, return <see cref="ButtonVisibility.Available"/>,
    /// otherwise <see cref="ButtonVisibility.None"/>,
    /// otherwise return </summary>
    /// <param name="granted"></param>
    /// <param name="require"></param>
    /// <returns></returns>

    static public ButtonVisibility ButtonAvailableNone(
            this Privilege granted, Privilege require) =>
         ((granted & require) == require) ? ButtonVisibility.Available : ButtonVisibility.None;


    /// <summary>If the privilege <paramref name="granted"/> has the bits specified by
    /// <paramref name="require"/> set, return <see cref="ButtonVisibility.Checked"/> if 
    /// <paramref name="isActive"/> is true and <see cref="ButtonVisibility.Available"/> ,
    /// otherwise <see cref="ButtonVisibility.Disabled"/>,
    /// otherwise return </summary>
    /// <param name="granted"></param>
    /// <param name="require"></param>
    /// <returns></returns>
    static public ButtonVisibility ButtonCheckedAvailableDisabled(
            this Privilege granted, Privilege require, bool isActive) =>
        ((granted & require) == require) ? 
        (isActive ? ButtonVisibility.Checked : ButtonVisibility.Available) : ButtonVisibility.Disabled;

    }
