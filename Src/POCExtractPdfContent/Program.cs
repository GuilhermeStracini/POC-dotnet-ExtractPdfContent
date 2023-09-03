namespace POCExtractPdfContent;

internal static class Program
{
    private const string ExampleUrl =
        "https://www2.nuclea.com.br/Monitoramento/Participantes_Homologados.pdf";

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var extractor = new ITextSharpExample();
        var content = extractor.Extract(ExampleUrl);

        Console.WriteLine(content);
    }
}
