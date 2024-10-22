

namespace Cookie_Cookbook.FileAccess;

// Extension method 
public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat fileFormat) =>
        fileFormat == FileFormat.Json ? "json" : "txt";
}
