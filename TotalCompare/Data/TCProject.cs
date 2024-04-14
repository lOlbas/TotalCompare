namespace TotalCompare.Data;

[Serializable]
public struct TCProject
{
    public static int FormatVersion = 0;

    public string Name { get; set; }

    public TCSource Sources { get; set; }

    public List<TCSource> Views { get; set; }
}

public enum TCResolveType
{
    CommonBasePath = 0,
    SeparateBasePath = 1
}

[Serializable]
public struct TCSource
{
    /// <summary>
    /// Name of Source
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Used internally to differentiate between usages of <see cref="TCSource.Paths"/> and <see cref="TCSource.CommonBasePath"/>.
    /// </summary>
    public TCResolveType ResolveType { get; set; }

    // If `ResolveType` is CommonBasePath, this value is concatenated with Paths like `Paths[] + CommonBaseBath`,
    // otherwise `Paths[]` is expected to contain 
    public string? CommonBasePath { get; set; }

    /// <summary>
    /// List of paths relative to <see cref="TCSource.Paths"/> or <see cref="TCSource.CommonBasePath"/>.
    /// </summary>
    public List<string>? Paths { get; set; }

    /// <summary>
    /// List of files or directories to ignore during comparison. Syntax of entries is the same as in gitignore.
    /// </summary>
    public List<string> IgnoreList { get; set; }
}

[Serializable]
public struct TCView
{
    /// <summary>
    /// Name of View
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Used internally to differentiate between usages of <see cref="TCView.Paths"/> and <see cref="TCView.CommonBasePath"/>.
    /// </summary>
    public TCResolveType ResolveType { get; set; }

    /// <summary>
    /// If this field is null, <see cref="TCView.Paths"/> is expected to contain list of directories or files paths relative to <see cref="TCSource.Paths"/> or <see cref="TCSource.CommonBasePath"/>.
    /// If this field is not null, <see cref="TCView.CommonBasePath"/> is appended to <see cref="TCView.Paths"/>.
    /// </summary>
    public string? CommonBasePath { get; set; }

    /// <summary>
    /// List of paths relative to <see cref="TCSource.Paths"/> or <see cref="TCSource.CommonBasePath"/>.
    /// </summary>
    public List<string>? Paths { get; set; }

    /// <summary>
    /// Primary source used during diff generation. If null, files are compared left to right.
    /// </summary>
    public string? PrimarySource { get; set; }

    /// <summary>
    /// List of files or directories to ignore during comparison. Syntax of entries is the same as in gitignore.
    /// </summary>
    public List<string> IgnoreList { get; set; }

    /// <summary>
    /// Whether to inherit <see cref="TCSource.IgnoreList"/> or not.
    /// </summary>
    public bool InheritSourceIgnoreList { get; set; }
}
