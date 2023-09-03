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
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var extractor = new PdfPigExample();
        var content = extractor.Extract(ExampleUrl);

        Console.WriteLine(content);
    }
}
