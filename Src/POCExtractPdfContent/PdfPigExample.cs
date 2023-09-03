using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;

namespace POCExtractPdfContent;

/// <summary>
/// Class PdfPigExample.
/// Implements the <see cref="POCExtractPdfContent.IPdfExtractor" />
/// </summary>
/// <seealso cref="POCExtractPdfContent.IPdfExtractor" />
public class PdfPigExample : IPdfExtractor
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
