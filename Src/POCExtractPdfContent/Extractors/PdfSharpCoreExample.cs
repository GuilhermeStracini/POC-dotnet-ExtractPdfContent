using PdfSharpCore.Pdf.IO;

namespace POCExtractPdfContent.Extractors;

public class PdfSharpCoreExample : IPdfExtractor
{
    public string Extract(string path)
    {
        var data = Helper.DownloadContent(path);
        var memoryStream = new MemoryStream();
        memoryStream.Write(data);
        memoryStream.Seek(0, SeekOrigin.Begin);

        var pdf = PdfReader.Open(memoryStream);
        var page = pdf.Pages[0];
        var text = page.Contents.ToString();

        return text;
    }
}
