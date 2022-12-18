﻿
namespace ImageGlass.Base;

/// <summary>
/// Directory name constants
/// </summary>
public static class Dir
{
    /// <summary>
    /// Gets the Themes folder name
    /// </summary>
    public static string Themes { get; } = "Themes";

    /// <summary>
    /// Gets the Icons folder name
    /// </summary>
    public static string Icons { get; } = "Icons";

    /// <summary>
    /// Gets the Ext-Icons folder name
    /// </summary>
    public static string ExtIcons { get; } = "Ext-Icons";

    /// <summary>
    /// Gets the Languages folder name
    /// </summary>
    public static string Languages { get; } = "Languages";

    /// <summary>
    /// Gets the cached thumbnails folder name
    /// </summary>
    public static string ThumbnailsCache { get; } = "ThumbnailsCache";

    /// <summary>
    /// Gets the temporary folder name
    /// </summary>
    public static string Temporary { get; } = "Temp";

#if DEBUG
    /// <summary>
    /// Logging should not be to the temporary folder, as it is deleted on shutdown
    /// </summary>
    public static string Log { get; } = "Log";
#endif

}
