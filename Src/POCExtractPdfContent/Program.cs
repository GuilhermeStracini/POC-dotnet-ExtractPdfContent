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
        "https://www2.nuclea.com.br/Monitoramento/Participantes_Homologados.pdf";

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        var extractor = new PdfSharpCoreExample();
        var content = extractor.Extract(ExampleUrl);

        Console.WriteLine(content);
    }
}
