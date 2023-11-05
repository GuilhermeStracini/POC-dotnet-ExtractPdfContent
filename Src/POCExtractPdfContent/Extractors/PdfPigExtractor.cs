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
    /// Extracts the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>System.String.</returns>
    public string Extract(byte[] data)
    {
        var document = PdfDocument.Open(data);
        var page = document.GetPage(1);
        var text = ContentOrderTextExtractor.GetText(page);

        return text;
    }
}
