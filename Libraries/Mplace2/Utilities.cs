using Goedel.Discovery;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Frame;


/// <summary>
/// General utilities class.
/// </summary>
public static class Utilities {

    /*
     * Functions that vary by the site.
     */


    /// <summary>
    /// Return the link to the page of user <paramref name="uid"/>
    /// </summary>
    /// <param name="uid">The user to return the page for.</param>
    /// <returns>The link.</returns>
    public static string GetUserAnchor(string? uid) => $"User?{uid}";


    /// <summary>
    /// Return the link to the page of post <paramref name="uid"/>
    /// </summary>
    /// <param name="uid">The post to return the page for.</param>
    /// <returns>The link.</returns>
    public static string GetPostAnchor(string? uid) => $"Post?{uid}";


    /// <summary>
    /// Return the link to the page of comment <paramref name="uid"/>
    /// </summary>
    /// <param name="uid">The comment to return the page for.</param>
    /// <returns>The link.</returns>
    public static string GetCommentAnchor(string? uid) => $"Comment?{uid}";





    /*
     * Derrived functions
     */

    /// <summary>
    /// Return a backing link for the page of user <paramref name="uid"/> with 
    /// the text description <paramref name="text"/>.
    /// </summary>
    /// <param name="text">The text to display.</param>
    /// <param name="uid">The user's handle.</param>
    /// <returns>The backing link.</returns>
    public static BackingTypeLink GetUserPage(string? text, string? uid) => 
                new (text, GetUserAnchor(uid));

    /// <summary>
    /// Return a backing link for the page of post <paramref name="uid"/> with 
    /// the text description <paramref name="text"/>.
    /// </summary>
    /// <param name="text">The text to display.</param>
    /// <param name="uid">The user's handle.</param>
    /// <returns>The backing link.</returns>
    public static BackingTypeLink GetPostPage(string? text, string? uid) =>
                new (text, GetPostAnchor(uid));



    }