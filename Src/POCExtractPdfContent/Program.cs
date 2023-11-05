using POCExtractPdfContent.Extractors;

namespace POCExtractPdfContent;

/// <summary>
/// Class Program.
/// </summary>
internal static class Program
{
    /// <summary>
    /// The example URL
    /// </summary>
    private const string ExampleUrl =
#pragma warning disable S1075
        "https://www2.nuclea.com.br/Monitoramento/Participantes_Homologados.pdf";
#pragma warning restore S1075

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        var data = Helper.DownloadContent(ExampleUrl);

        Console.WriteLine("Hello, World!");

        var docNet = new DocNetExtractor();
        var docNetContent = docNet.Extract(data);
        Console.WriteLine(docNetContent);

        var pdfPig = new PdfPigExtractor();
        var pdfPigContext = pdfPig.Extract(data);
        Console.WriteLine(pdfPigContext);

        var textSharp = new TextSharpExtractor();
        var textSharpContent = textSharp.Extract(data);
        Console.WriteLine(textSharpContent);
    }
}
