using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

namespace POCExtractPdfContent.Extractors;

/// <summary>
/// Class PdfPigExtractor.
/// Implements the <see cref="IPdfExtractor" />
/// </summary>
/// <seealso cref="IPdfExtractor" />
public class PdfPigExtractor : IPdfExtractor
{
    /// <summary>
    /// Extracts the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.String.</returns>
    public string Extract(string path)
    {
        var data = Helper.DownloadContent(path);
        var document = PdfDocument.Open(data);
        var page = document.GetPage(1);
        var text = ContentOrderTextExtractor.GetText(page);

        return text;
    }
}
