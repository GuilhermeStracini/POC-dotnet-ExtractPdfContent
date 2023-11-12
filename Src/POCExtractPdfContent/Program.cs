using POCExtractPdfContent.Extractors;

namespace POCExtractPdfContent;

/// <summary>
/// Class Program.
/// </summary>
internal static class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        Console.Write("Inform the PDF url: ");
        var url = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(url))
        {
            Console.WriteLine("Invalid PDF url!");
            return;
        }

        var data = Helper.DownloadContent(url);

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("DocNet");
        Console.WriteLine("---------------------------------------------------------------");
        var docNet = new DocNetExtractor();
        var docNetContent = docNet.Extract(data);
        Helper.SaveContent("DocNet", docNetContent);
        Console.WriteLine(docNetContent);
        Console.WriteLine("\r\n");

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("PdfPig");
        Console.WriteLine("---------------------------------------------------------------");
        var pdfPig = new PdfPigExtractor();
        var pdfPigContent = pdfPig.Extract(data);
        Helper.SaveContent("PdfPig", pdfPigContent);
        Console.WriteLine(pdfPigContent);
        Console.WriteLine("\r\n");

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("iTextShaper");
        Console.WriteLine("---------------------------------------------------------------");
        var textSharp = new TextSharpExtractor();
        var textSharpContent = textSharp.Extract(data);
        Helper.SaveContent("iTextSharp", textSharpContent);
        Console.WriteLine(textSharpContent);
        Console.WriteLine("\r\n");
    }
}
