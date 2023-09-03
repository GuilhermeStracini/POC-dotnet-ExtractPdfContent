using iTextSharp.text.pdf;
using System.Text;

namespace POCExtractPdfContent;

/// <summary>
/// Class ITextSharpExample.
/// Implements the <see cref="POCExtractPdfContent.IPdfExtractor" />
/// </summary>
/// <seealso cref="POCExtractPdfContent.IPdfExtractor" />
public class ITextSharpExample : IPdfExtractor
{
    /// <summary>
    /// Extracts the specified path.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>System.String.</returns>
    public string Extract(string path)
    {
        var stringsList = new List<string>();
        var reader = new PdfReader(new Uri(path));

        var contentBytes = reader.GetPageContent(1);
        var tokenizer = new PrTokeniser(new RandomAccessFileOrArray(contentBytes));

        while (tokenizer.NextToken())
        {
            if (tokenizer.TokenType == PrTokeniser.TK_STRING)
            {
                var currentText = tokenizer.StringValue;
                currentText = Encoding.UTF8.GetString(
                    ASCIIEncoding.Convert(
                        Encoding.Default,
                        Encoding.UTF8,
                        Encoding.Default.GetBytes(currentText)
                    )
                );
                stringsList.Add(currentText);
            }
        }

        reader.Close();

        return string.Join("", stringsList);
    }
}
