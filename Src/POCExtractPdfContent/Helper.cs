using iTextSharp.text.pdf;
using iTextSharp.text;

namespace POCExtractPdfContent;

/// <summary>
/// Class Helper.
/// </summary>
public static class Helper
{
    /// <summary>
    /// Downloads the content.
    /// </summary>
    /// <param name="url">The URL.</param>
    /// <returns>System.Byte[].</returns>
    public static byte[] DownloadContent(string url)
    {
        using var httpClient = new HttpClient();
        return httpClient.GetByteArrayAsync(url).Result;
    }

    /// <summary>
    /// Creates the sample PDF file.
    /// </summary>
    /// <returns>System.Byte[].</returns>
    public static byte[] CreateSamplePdfFile()
    {
        using var stream = new MemoryStream();
        using (var document = new Document())
        {
            var writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Guilherme Branco Stracini");
            document.Open();
            document.Add(new Paragraph("Hello World - PDF Extractor example!"));

            document.NewPage();
            document.Add(new Phrase(""));

            document.NewPage();
            writer.PageEmpty = false;
        }

        return stream.ToArray();
    }

    /// <summary>
    /// Saves the content.
    /// </summary>
    /// <param name="library">The library.</param>
    /// <param name="content">The content.</param>
    public static void SaveContent(string library, string content)
    {
        var fileName = $"result-{library}.txt";
        File.WriteAllText(fileName, content);
    }
}
