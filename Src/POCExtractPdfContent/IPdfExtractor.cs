namespace POCExtractPdfContent;

/// <summary>
/// Interface IPdfExtractor
/// </summary>
public interface IPdfExtractor
{
    /// <summary>
    /// Extracts the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.String.</returns>
    string Extract(string path);
}
