namespace POCExtractPdfContent.Extractors;

/// <summary>
/// Interface IPdfExtractor
/// </summary>
public interface IPdfExtractor
{
    /// <summary>
    /// Extracts the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>System.String.</returns>
    string Extract(byte[] data);
}
