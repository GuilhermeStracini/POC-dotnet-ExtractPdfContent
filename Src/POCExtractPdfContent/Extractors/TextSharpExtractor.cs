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
        var reader = new PdfReader(data);

        var contentBytes = reader.GetPageContent(1);
        var tokenizer = new PrTokeniser(new RandomAccessFileOrArray(contentBytes));

        while (tokenizer.NextToken())
        {
            if (tokenizer.TokenType == PrTokeniser.TK_STRING)
            {
                var currentText = tokenizer.StringValue;
                currentText = Encoding.UTF8.GetString(
                    Encoding.Convert(
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
