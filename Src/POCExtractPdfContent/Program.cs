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
        Console.WriteLine("Hello, World!");

        var extractor = new DocnetExample();
        var content = extractor.Extract(ExampleUrl);

        Console.WriteLine(content);
    }
}
