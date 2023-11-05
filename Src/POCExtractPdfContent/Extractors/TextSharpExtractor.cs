using iTextSharp.text.pdf;
using System.Text;

namespace POCExtractPdfContent.Extractors;

/// <summary>
/// Class ITextSharpExtractor.
/// Implements the <see cref="IPdfExtractor" />
/// </summary>
/// <seealso cref="IPdfExtractor" />
public class TextSharpExtractor : IPdfExtractor
{
    /// <summary>
    /// Extracts the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>System.String.</returns>
    public string Extract(byte[] data)
    {
        var stringsList = new List<string>();
        using var reader = new PdfReader(data);

        var contentBytes = reader.GetPageContent(1);
        var tokenizer = new PrTokeniser(new RandomAccessFileOrArray(contentBytes));

        while (tokenizer.NextToken())
        {
            if (tokenizer.TokenType != PrTokeniser.TK_STRING)
            {
                continue;
            }

            stringsList.Add(tokenizer.StringValue);
        }

        return string.Join("", stringsList);
    }
}
