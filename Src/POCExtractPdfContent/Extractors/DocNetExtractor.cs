using Docnet.Core.Models;
using Docnet.Core;

namespace POCExtractPdfContent.Extractors;

/// <summary>
/// Class DocNetExtractor.
/// </summary>
public class DocNetExtractor : IPdfExtractor
{
    /// <summary>
    /// Extracts the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>System.String.</returns>
    public string Extract(byte[] data)
    {
        using var docReader = DocLib.Instance.GetDocReader(data, new PageDimensions());
        var page = docReader.GetPageReader(0);
        var text = page.GetText();
        return text;
    }
}
