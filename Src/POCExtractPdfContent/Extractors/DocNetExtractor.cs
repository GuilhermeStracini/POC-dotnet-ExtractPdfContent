using Docnet.Core.Models;
using Docnet.Core;

namespace POCExtractPdfContent.Extractors;

/// <summary>
/// Class DocNetExtractor.
/// </summary>
public class DocNetExtractor : IPdfExtractor
{
    /// <summary>
    /// Extracts the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.String.</returns>
    public string Extract(string path)
    {
        var data = Helper.DownloadContent(path);
        using var docReader = DocLib.Instance.GetDocReader(data, new PageDimensions());
        var page = docReader.GetPageReader(1);
        var text = page.GetText();
        return text;
    }
}
